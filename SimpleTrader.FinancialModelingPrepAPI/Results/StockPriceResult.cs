using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.FinancialModelingPrepAPI.Results
{
    public class StockPriceResult
    {
        public List<CompaniesPriceList> CompaniesPriceList { get; set; }
    }

    public class CompaniesPriceList
    {
        public string Symbol { get; set; }
        public double Price { get; set; }
    }
}
