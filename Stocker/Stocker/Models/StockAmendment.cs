using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocker.Models
{
    //Enum for AmendedReasonType???


    public class StockAmendment
    {
        public int StockAmendmentID { get; set; }
        public int StockID { get; set; }
        public int UserID { get; set; }
        public DateTime AmendmentDate { get; set; }
        public string AmendedReasontype { get; set; }
    }
}
