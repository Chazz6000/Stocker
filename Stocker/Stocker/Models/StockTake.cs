using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocker.Models
{
    public class StockTake
    {
        public int StokeTakeID { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public int UserID { get; set; }
        public int StockTakeItemsID { get; set; }
    }
}
