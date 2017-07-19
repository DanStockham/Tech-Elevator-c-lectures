using HistoryGeek.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryGeek.Web.DataAccess
{
    public interface IUserDAL
    {
        User GetUser(string email);
        void SaveUser(User user);
    }
}
