using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GBCE;
namespace GBCE
{
    interface IStockDAL
    {
        void AddStock(Stock stock);
        Stock GetStock(string symbol);
    }
}
