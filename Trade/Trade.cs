using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBCE
{
    public class Trade
    {
        public Stock Stock { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Quantity { get; set; }
        public TradeType Type { get; set; }
        public double Price { get; set; }
    }
}
