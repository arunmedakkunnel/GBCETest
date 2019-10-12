using System.Collections.Generic;
using System.Linq;
using GBCE;
namespace GBCE
{
    public class StockDAL:IStockDAL
    {
        private List<Stock> StockData = null;
        public StockDAL()
        {
            StockData = new List<Stock>();
            var stock1 = new Stock
            {
                Symbol = "TEA",
                Type = StockType.Common,
                LastDividend = 0,
                ParValue = 100
            };
            var stock2 = new Stock
            {
                Symbol = "POP",
                Type = StockType.Common,
                LastDividend = 8,
                ParValue = 100
            };
            var stock3 = new Stock
            {
                Symbol = "ALE",
                Type = StockType.Common,
                LastDividend = 23,
                ParValue = 60
            };
            var stock4 = new Stock
            {
                Symbol = "GIN",
                Type = StockType.Preffered,
                LastDividend = 8,
                FixedDividend = 2,
                ParValue = 100
            };
            var stock5 = new Stock
            {
                Symbol = "JOE",
                Type = StockType.Common,
                LastDividend = 13,
                ParValue = 250
            };
            StockData.Add(stock1);
            StockData.Add(stock2);
            StockData.Add(stock3);
            StockData.Add(stock4);
            StockData.Add(stock5);
        }
        public Stock GetStock(string symbol)
        {
            return StockData.Where(s => s.Symbol == symbol).FirstOrDefault();
        }

        public void AddStock(Stock stock)
        {
            StockData.Add(stock);
        }
    }
}
