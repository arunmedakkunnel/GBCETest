using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBCE
{
    public class Stock
    {
        public string Symbol { get; set; }
        public StockType Type { get; set; }
        public int LastDividend { get; set; }
        public int FixedDividend { get; set; }
        public int ParValue { get; set; }
    }
}
