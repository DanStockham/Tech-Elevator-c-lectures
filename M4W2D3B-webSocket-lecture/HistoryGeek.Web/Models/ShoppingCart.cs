using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryGeek.Web.Models
{
    public class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        /// <summary>
        /// Adds a product to the shopping cart. If it is already in the cart, updates the quantity.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        public void AddToCart(Product product, int quantity)
        {
            ShoppingCartItem existingItem = Items.FirstOrDefault(i => i.Product.SKU == product.SKU);
            if (existingItem == null)
            {
                Items.Add(new ShoppingCartItem() { Product = product, Quantity = quantity });
            }
            else
            {
                existingItem.Quantity += quantity;
            }
        }

        /// <summary>
        /// Get the subtotal of all items in the shopping cart.
        /// </summary>
        public double SubTotal
        {
            get
            {
                return Items.Sum(p => p.Price);
            }
        }
    }
}