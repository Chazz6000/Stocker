using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocker.Models
{
    public class StockTakeItems
    {
        public int StockTakeItemsID { get; set; }
        public int StockID  { get; set; }
        public int Volume { get; set; }
    }
}
