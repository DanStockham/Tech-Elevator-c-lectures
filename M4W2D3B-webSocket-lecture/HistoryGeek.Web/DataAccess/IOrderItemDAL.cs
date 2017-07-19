using HistoryGeek.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryGeek.Web.DataAccess
{
    public interface IOrderItemDAL
    {
        List<OrderItem> GetOrderItems(int orderId);
        void SaveOrderItems(List<OrderItem> newItems);
    }
}
