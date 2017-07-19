using HistoryGeek.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryGeek.Web.DataAccess
{
    public interface IProductDAL
    {
        /// <summary>
        /// Returns back a list of all active products.
        /// </summary>
        /// <returns></returns>
        List<Product> GetProducts();

        /// <summary>
        /// Returns a single product given a sku.
        /// </summary>
        /// <param name="sku"></param>
        /// <returns></returns>
        Product GetProduct(string sku);
    }
}
