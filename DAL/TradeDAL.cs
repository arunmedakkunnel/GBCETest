using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBCE
{
    public class TradeDAL : ITradeDAL
    {
        private List<Trade> trades = null;
        public TradeDAL()
        {
            trades = new List<Trade>();
            var trade1 = new Trade
            {
                Stock = new Stock
                {
                    Symbol = "TEA",
                    Type = StockType.Common,
                    LastDividend = 0,
                    ParValue = 100
                },
                TimeStamp = DateTime.Now,
                Quantity = 10,
                Type = TradeType.Buy,
                Price = 110
            };
            var trade2= new Trade
            {
                Stock = new Stock
                {
                    Symbol = "POP",
                    Type = StockType.Common,
                    LastDividend = 8,
                    ParValue = 100
                },
                TimeStamp = DateTime.Now,
                Quantity = 10,
                Type = TradeType.Buy,
                Price = 110
            };
            var trade3 = new Trade
            {
                Stock = new Stock
                {
                    Symbol = "ALE",
                    Type = StockType.Common,
                    LastDividend = 23,
                    ParValue = 60
                },
                TimeStamp = DateTime.Now,
                Quantity = 30,
                Type = TradeType.Sell,
                Price = 70
            };
        }
        public void AddTrade(Trade trade)
        {
            trades.Add(trade);
        }

        public List<Trade> GetAllTrades()
        {
            return trades;
        }

        public List<Trade> GetTrade(Stock Stock, DateTime time)
        {
            return trades.Where(t => t.Stock.Equals(Stock) && t.TimeStamp.Minute<(time.Minute-5)).ToList();
        }
    }
}
