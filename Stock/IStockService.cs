using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBCE
{
    public interface IStockService
    {
        void AddStock(Stock stock);
        Stock GetStock(string symbol);

        double CalculateDividend(Stock stock, double price);

        double CalculatePERatio(Stock stock, double price);

        double CalculateGBCE(List<Trade> trades);

        double CalculateVolumeWeightedStockPrice(List<Trade> trades);
    }
}
