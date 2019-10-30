using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontBlazorApp.Data
{
    public class Observation
    {
        public string daylight { get; set; }
        public string description { get; set; }
        public string skyInfo { get; set; }
        public string skyDescription { get; set; }
        public float temperature { get; set; }
        public string temperatureDesc { get; set; }
        public string comfort { get; set; }
        public string highTemperature { get; set; }
        public string lowTemperature { get; set; }
        public string humidity { get; set; }
        public string dewPoint { get; set; }
        public string precipitation1H { get; set; }
        public string precipitation3H { get; set; }
        public string precipitation6H { get; set; }
        public string precipitation12H { get; set; }
        public string precipitation24H { get; set; }
        public string precipitationDesc { get; set; }
        public string airInfo { get; set; }
        public string airDescription { get; set; }
        public string windSpeed { get; set; }
        public string windDirection { get; set; }
        public string windDesc { get; set; }
        public string windDescShort { get; set; }
        public string barometerPressure { get; set; }
        public string barometerTrend { get; set; }
        public string visibility { get; set; }
        public string snowCover { get; set; }
        public string icon { get; set; }
        public string iconName { get; set; }
        public string iconLink { get; set; }
        public string ageMinutes { get; set; }
        public string activeAlerts { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double distance { get; set; }
        public double elevation { get; set; }
        public DateTime utcTime { get; set; }
    }

    public class Location
    {
        public List<Observation> observation { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double distance { get; set; }
        public int timezone { get; set; }
    }

    public class Observations
    {
        public List<Location> location { get; set; }
    }

    public class RootObject
    {
        public Observations observations { get; set; }
        public DateTime feedCreation { get; set; }
        public bool metric { get; set; }
    }
}
