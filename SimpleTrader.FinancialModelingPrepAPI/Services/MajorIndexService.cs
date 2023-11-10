﻿using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace SimpleTrader.FinancialModelingPrepAPI.Services
{
    public class MajorIndexService : IMajorIndexService
    {
        public async Task<MajorIndex> GetMajorIndex(MajorIndexType indexType)
        {
            using (FinancialModelingPrepHttpClient client = new FinancialModelingPrepHttpClient())
            {
                var uri = "majors-indexes/" + GetUriSuffix(indexType) + "?apikey=f31lQtz8FpWWKv76av1C1gwMPfcfEzLJ";

                MajorIndex majorIndex = await client.GetAsync<MajorIndex>(uri);
                majorIndex.Type=indexType;
                return majorIndex;
            }
        }

        private string GetUriSuffix(MajorIndexType indexType)
        {
            switch (indexType)
            {
                case (MajorIndexType.DowJones):
                    return ".DJI";
                case (MajorIndexType.Nasdaq):
                    return ".IXIC";
                case (MajorIndexType.SP500):
                    return ".INX";
                default:
                    throw new Exception("MajorIndexType does not have a suffix defined.");
            }
        }
    }
}
