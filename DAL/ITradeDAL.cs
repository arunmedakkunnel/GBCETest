﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBCE
{
    interface ITradeDAL
    {
        void AddTrade(Trade trade);
        List<Trade> GetTrade(Stock Stock, DateTime time);
        List<Trade> GetAllTrades();
    }
}
