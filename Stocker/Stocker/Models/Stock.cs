using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocker.Models
{

    public enum eStockType
    {
        eComputer,
        eLaptop
    }
        

    

    public class Stock
    {
        public int StockID { get; set; }
        public eStockType StockType { get; set; }
        public  string Name { get; set; }
        public string LocationID { get; set; }
        public int Volume { get; set; }
    }
}
