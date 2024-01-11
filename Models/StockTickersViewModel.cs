﻿namespace Inz_Fn.Models
{
    public class StockTickersViewModel
    {
        internal string? searchStr;

        public List<StockTickers> StockTickers { get; set; }
        public PaginationModel Pagination { get; set; }
        public List<string> StockTickerCIK { get; internal set; }
    }
}
