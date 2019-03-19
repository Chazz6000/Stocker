using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocker.Models
{

    public enum StockType
    {
        Computer,
        Laptop
    }
        

    

    public class Stock
    {
        public int StockID { get; set; }
        public StockType StockType { get; set; }
        public  string Name { get; set; }
        public string LocationID { get; set; }
        public int Volume { get; set; }
    }
}
