using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HistoryGeek.Web.Models;
using System.Data.SqlClient;
using Dapper;

namespace HistoryGeek.Web.DataAccess
{
    public class ProductSqlDAL : IProductDAL
    {
        private readonly string connectionString;

        public ProductSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Product GetProduct(string sku)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    //TODO: Discuss if this can stay or convert to SqlDataReader
                    var result = conn.QueryFirstOrDefault<Product>("SELECT * FROM products WHERE sku = @skuValue", new { skuValue = sku });
                    return result;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public List<Product> GetProducts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    //TODO: Discuss if this can stay or convert to SqlDataReader
                    var result = conn.Query<Product>("SELECT * FROM products");
                    return result.ToList();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}