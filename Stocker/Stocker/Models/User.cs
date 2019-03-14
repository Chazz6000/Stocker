using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocker.Models
{
    public enum UserType
    {
        StockController,
        StockMonitor
    }



    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public DateTime LastLogin { get; set; }




    }
}
