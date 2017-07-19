using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HistoryGeek.Web.Models;
using Dapper;
using System.Data.SqlClient;

namespace HistoryGeek.Web.DataAccess
{
    public class OrderItemSqlDAL : IOrderItemDAL
    {
        private readonly string connectionString;

        public OrderItemSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<OrderItem> GetOrderItems(int orderId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var result = conn.Query<OrderItem>("SELECT * FROM order_items WHERE orderId = @orderIdValue", new { orderIdValue = orderId });
                    return result.ToList();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public void SaveOrderItems(List<OrderItem> newItems)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    
                    foreach (var item in newItems)
                    {

                        conn.Execute("INSERT INTO order_items VALUES (@orderId, @productId, @quantity, @price);", 
                            new {
                                orderId = item.OrderId,
                                productId = item.ProductId,
                                quantity = item.Quantity,
                                price = item.Price
                            });

                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}