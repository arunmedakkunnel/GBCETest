using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBCE
{
    public class TradeServices : ITradeService
    {
        private static TradeServices instance = null;
        private static object sync = new object();
        TradeDAL tradeDAL = new TradeDAL();
        private TradeServices()
        {
        }
        public static TradeServices GetInstance()
        {
            if (instance == null)
            {
                lock(sync)
                {
                    if (instance == null)
                        instance = new TradeServices();
                }
            }
            return instance;
        }
        public List<Trade> GetAllTrades()
        {
            return tradeDAL.GetAllTrades();
        }

        public List<Trade> GetTrade(Stock stock, DateTime time)
        {
            return tradeDAL.GetTrade(stock, time);
        }

        public void RecordTrade(Trade trade)
        {
                tradeDAL.AddTrade(trade);
        }
    }
}
