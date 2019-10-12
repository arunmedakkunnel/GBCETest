using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBCE
{
    public sealed class StockService : IStockService
    {
        StockDAL stockDAL = new StockDAL();
        private static StockService instance =null;
        private static object sync = new object();
        private StockService()
        {
        }
        public static StockService GetInstance()
        {
            if (instance == null)
            {
                lock (sync)
                {
                    if (instance == null)
                        instance = new StockService();
                }
            }
            return instance;
        }
        public void AddStock(Stock stock)
        {
            stockDAL.AddStock(stock);
        }

        public double CalculateDividend(Stock stock, double price)
        {
            if(stock.Type == StockType.Preffered)
            {
                return (stock.FixedDividend * stock.ParValue) / price;
            }
            return stock.FixedDividend / price;
        }

        public double CalculateGBCE(List<Trade> trades)
        {
            double total=1;
            foreach(Trade trade in trades)
            {
                total = total * trade.Price;
            }
            return Math.Pow(total, (1D / trades.Count()));            
        }

        public double CalculatePERatio(Stock stock, double price)
        {
            return price / stock.LastDividend;
        }

        public double CalculateVolumeWeightedStockPrice(List<Trade> trades)
        {
            double SumPriceQuantity = 0;
            int SumQuantity = 0;
            foreach(Trade trade in trades)
            {
                SumPriceQuantity = SumPriceQuantity + (trade.Price * trade.Quantity);
                SumQuantity = SumQuantity + trade.Quantity;
            }
            return SumPriceQuantity / SumQuantity;
        }

        public Stock GetStock(string symbol)
        {
            return stockDAL.GetStock(symbol);
        }
    }
}
