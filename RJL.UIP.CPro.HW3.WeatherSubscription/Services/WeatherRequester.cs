using OpenWeatherAPI;
using RJL.UIP.CPro.HW3.WeatherSubscription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW3.WeatherSubscription.Services
{
    class WeatherRequester
    {
        public string APIKey { get; set; }
        public string City { get; set; }

        public WeatherRequester(string APIKey, string city)
        {
            this.APIKey = APIKey;
            this.City = city;
        }

        public WeatherForecast GetForecast()
        {
            var client = new OpenWeatherAPI.OpenWeatherAPI(APIKey);
            var results = client.Query(City);
            WeatherForecast weather = new WeatherForecast();
            weather.Temperature = results.Main.Temperature.ToString();
            weather.WindSpeed = results.Wind.SpeedFeetPerSecond.ToString();
            weather.Pressure = results.Main.Pressure.ToString();
            weather.City = this.City;
            weather.DTime = DateTime.Now;
            return weather;
        }


    }
}
