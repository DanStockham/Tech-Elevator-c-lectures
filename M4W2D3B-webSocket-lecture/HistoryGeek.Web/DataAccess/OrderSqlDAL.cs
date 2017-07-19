using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HistoryGeek.Web.Models;
using Dapper;
using System.Data.SqlClient;

namespace HistoryGeek.Web.DataAccess
{
    public class OrderSqlDAL : IOrderDAL
    {
        private readonly string connectionString;

        public OrderSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Order GetOrder(int orderId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Order order = conn.QueryFirstOrDefault<Order>("SELECT * FROM orders WHERE id = @orderId", new { orderId = orderId });
                    return order;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }            
        }

        public List<Order> GetOrders(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.Open();
                    var result = conn.Query<Order>("SELECT * FROM orders WHERE userId = @userValue", new { userValue = userId });
                    return result.ToList();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public void SaveOrder(Order newOrder)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO orders (userId, billingAddress1, billingAddress2, billingCity, billingState, billingPostalCode,
                                    shippingAddress1, shippingAddress2, shippingCity, shippingState, shippingPostalCode, 
                                    subTotal, weight, shippingType, shipping, tax, 
                                    creditCardNumber, nameOnCard, expirationDate) 
                                    VALUES (@userId, 
                                    @billingAddress1, @billingAddress2, @billingCity, @billingState, @billingPostalCode,
                                    @shippingAddress1, @shippingAddress2, @shippingCity, @shippingState, @shippingPostalCode,
                                    @subTotal, @weight, @shippingType, @shipping, @tax, 
                                    @creditCardNumber, @nameOnCard, @expirationDate); SELECT CAST(SCOPE_IDENTITY() as int);";
                    newOrder.Id = conn.Query<int>(sql, new
                    {
                        userId = newOrder.UserId,
                        billingAddress1 = newOrder.BillingAddress1,
                        billingAddress2 = newOrder.BillingAddress2,
                        billingCity = newOrder.BillingCity,
                        billingState = newOrder.BillingState,
                        billingPostalCode = newOrder.BillingPostalCode,
                        shippingAddress1 = newOrder.ShippingAddress1,
                        shippingAddress2 = newOrder.ShippingAddress2,
                        shippingCity = newOrder.ShippingCity,
                        shippingState = newOrder.ShippingState,
                        shippingPostalCOde = newOrder.ShippingPostalCode,
                        subTotal = newOrder.SubTotal,
                        weight = newOrder.Weight,
                        shippingType = newOrder.ShippingType,
                        shipping = newOrder.Shipping.Value,
                        tax = newOrder.Tax.Value,
                        creditCardNumber = newOrder.CreditCardNumber,
                        nameOnCard = newOrder.NameOnCard,
                        expirationDate = newOrder.ExpirationDate
                    }).First();
                }                
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}