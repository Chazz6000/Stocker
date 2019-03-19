using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocker.Models
{
    public class Sale
    {
        public int SaleID { get; set; }
        public int StockID { get; set; }
        public int UserID { get; set; }
        private int Volume { get; set; }
        public DateTime SoldDate { get; set; }

    }
}
