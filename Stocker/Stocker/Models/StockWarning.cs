using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocker.Models
{
    public enum WarningType
    {
        under,
        over
    }

    public class StockWarning
    {
        public int WarningID { get; set; }
        public WarningType WarningType { get; set; }
        public string Description { get; set; }
    }
}
