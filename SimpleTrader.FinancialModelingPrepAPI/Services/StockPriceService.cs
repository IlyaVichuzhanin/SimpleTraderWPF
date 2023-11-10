using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SimpleTrader.Domain.Exceptions;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.FinancialModelingPrepAPI.Results;

namespace SimpleTrader.FinancialModelingPrepAPI.Services
{
    public class StockPriceService : IStockPriceService
    {
        public async Task<double> GetPrice(string symbol)
        {



            using (FinancialModelingPrepHttpClient client = new FinancialModelingPrepHttpClient())
            {
                string uri = "stock/real-time-price/" + symbol + "?apikey=f31lQtz8FpWWKv76av1C1gwMPfcfEzLJ";
                StockPriceResult stockPriceResult = await client.GetAsync<StockPriceResult>(uri);


                if (stockPriceResult.CompaniesPriceList[0].Price == 0)
                {
                    throw new InvalidSymbolException(symbol);
                }

                return stockPriceResult.CompaniesPriceList[0].Price;
            }
        }
    }
}
