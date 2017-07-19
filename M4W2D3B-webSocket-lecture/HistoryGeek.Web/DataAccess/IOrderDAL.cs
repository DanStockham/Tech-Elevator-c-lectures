using HistoryGeek.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryGeek.Web.DataAccess
{
    public interface IOrderDAL
    {
        Order GetOrder(int orderId);
        List<Order> GetOrders(int userId);
        void SaveOrder(Order newOrder);
    }
}
