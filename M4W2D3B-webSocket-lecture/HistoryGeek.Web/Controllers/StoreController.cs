using HistoryGeek.Web.Calculators;
using HistoryGeek.Web.DataAccess;
using HistoryGeek.Web.Models;
using HistoryGeek.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Transactions;
using System.Web;
using System.Web.Mvc;

namespace HistoryGeek.Web.Controllers
{
    public class StoreController : Controller
    {
        private IProductDAL productDal;
        private IOrderDAL orderDal;
        private IOrderItemDAL orderItemDal;

        public StoreController(IProductDAL productDal, IOrderDAL orderDal, IOrderItemDAL orderItemDal)
        {
            this.productDal = productDal;
            this.orderDal = orderDal;
            this.orderItemDal = orderItemDal;
        }

        // GET: Store
        public ActionResult Index()
        {
            // Product Listing page
            return View("Index", productDal.GetProducts());
        }

        // GET: Store/Detail/{sku}
        public ActionResult Detail(string id)
        {
            var model = productDal.GetProduct(id);
            if (model == null)
            {
                return new HttpNotFoundResult();
            }

            return View("Detail", model);
        }

        // POST: Store/AddToCart
        [HttpPost]
        public ActionResult AddToCart(string sku, int quantity)
        {
            // Validate the SKU
            Product product = productDal.GetProduct(sku);
            if (product == null || quantity < 1)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // Update the Shopping Cart            
            ShoppingCart cart = GetActiveShoppingCart();
            cart.AddToCart(product, quantity);

            return RedirectToAction("ViewCart");
        }

        // POST: Store/UpdateCart
        [HttpPost]
        public ActionResult UpdateCart(string sku, int quantity)
        {
            // Update the quantity of an item in the cart
            ShoppingCart cart = GetActiveShoppingCart();

            if (quantity <= 0)
            {
                cart.Items.RemoveAll(i => i.Product.SKU == sku);
            }
            else
            {
                ShoppingCartItem item = cart.Items.FirstOrDefault(i => i.Product.SKU == sku);
                if (item != null)
                {
                    item.Quantity = quantity;
                }
            }

            return RedirectToAction("ViewCart");
        }

        // GET: Store/ViewCart
        public ActionResult ViewCart()
        {
            ShoppingCart cart = GetActiveShoppingCart();
            return View("ViewCart", cart);
        }

        // GET: Store/Checkout
        public ActionResult Checkout()
        {
            // If the user has not logged in yet, make them log in
            if(Session[SessionKeys.UserId] == null)
            {
                return RedirectToAction("Login", "User");
            }

            //Get their active shopping cart
            ShoppingCart cart = GetActiveShoppingCart();

            //If they don't have any items, redirect them to ViewCart
            if (cart.Items.Count == 0)
            {
                return RedirectToAction("ViewCart");
            }

            //Create an Order Model that sums up the item totals and weights
            Order model = new Order()
            {
                SubTotal = cart.SubTotal,
                Weight = cart.Items.Sum(m => m.Weight),                
            };

            //Set the shipping rates to use for the model
            model.ShippingRates = ShippingCalculator.GetShippingRates(model.Weight);

            return View("Checkout", model);
        }

        // POST: Store/Checkout
        [HttpPost]
        public ActionResult Checkout(Order order)
        {
            //Get their active shopping cart
            ShoppingCart cart = GetActiveShoppingCart();
            order.SubTotal = cart.SubTotal;
            order.Weight = cart.Items.Sum(i => i.Weight);

            if (!ModelState.IsValid)
            {
                order.ShippingRates = ShippingCalculator.GetShippingRates(order.Weight);
                return View("Checkout", order);
            }

            //Update the order with fields from the customer's checkout
            order.Tax = cart.SubTotal * TaxCalculator.GetTaxRate(order.BillingPostalCode);
            order.Shipping = ShippingCalculator.GetShippingRates(order.Weight)[order.ShippingType];
            order.UserId = (int)Session[SessionKeys.UserId];

            //Create a transaction to save these in the database
            //We want to make sure that the order is saved, along with each order item
            using (TransactionScope tran = new TransactionScope())
            {
                //Save the Order
                orderDal.SaveOrder(order);

                //Convert each "ShopingCartItem" to an "OrderItem" and give it the new order id
                List<OrderItem> orderItems = cart.Items.Select(c => new OrderItem
                {
                    Price = c.Price,
                    ProductId = c.Product.Id,
                    Quantity = c.Quantity,
                    OrderId = order.Id
                }).ToList();

                //Save the Order Items
                orderItemDal.SaveOrderItems(orderItems);

                //Empty the shopping cart
                Session.Remove(SessionKeys.Cart);

                //Save the transaction
                tran.Complete();
            }

            return RedirectToAction("Confirm", new { orderId = order.Id });
        }

        public ActionResult Confirm(int orderId)
        {
            //Build the view model and use the order, order items, and product purchased to populate it
            ConfirmationViewModel model = new ConfirmationViewModel()
            {
                Order = orderDal.GetOrder(orderId),
                OrderItems = orderItemDal.GetOrderItems(orderId),
                Products = productDal.GetProducts() //<-- so we can show each product
            };

            return View("Confirm", model);
        }

        // Returns the active shopping cart. If there isn't one, then one is created.
        private ShoppingCart GetActiveShoppingCart()
        {
            if (Session[SessionKeys.Cart] == null)
            {
                Session[SessionKeys.Cart] = new ShoppingCart();
            }

            return (ShoppingCart)Session[SessionKeys.Cart];
        }
    }
}