using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace WeatherGrpcService
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public async override Task<DataReply> GetData(DataRequest request, ServerCallContext context)
        {

            string app_id = "T0kuE2q26p99JvYjPjqe";
            string app_code = "6A9HQxNMarrXLakmgbQJzg";
            string page = string.Format("https://weather.api.here.com/weather/1.0/report.json?app_id={0}&app_code={1}&product=observation&name={2}", app_id, app_code, request.Name);

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)

            return await Task.FromResult(new DataReply
            {
                Message = await content.ReadAsStringAsync()
            });
        }


    }
}
