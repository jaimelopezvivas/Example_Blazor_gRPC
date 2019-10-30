using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherGrpcService;
using FrontBlazorApp.Data;

namespace FrontBlazorApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            DataReply response = client.GetData(new DataRequest() { Name = "Berlin" });
            RootObject res = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(response.Message);
            List<WeatherForecast> lstWeatherForecast = new List<WeatherForecast>();

            foreach (Location local in res.observations.location)
            {
                foreach (Observation obs in local.observation)
                {
                    WeatherForecast oWeather = new WeatherForecast();
                    oWeather.Date = res.feedCreation;
                    oWeather.TemperatureC = obs.temperature;
                    oWeather.Summary = string.Format("latitude  {0}, longitude {1}", local.latitude, local.longitude);
                    lstWeatherForecast.Add(oWeather);

                }
            }
            return Task.FromResult(lstWeatherForecast.ToArray());

        }
    }
}
