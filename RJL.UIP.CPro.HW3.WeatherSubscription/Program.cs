using OpenWeatherAPI;
using RJL.UIP.CPro.HW3.WeatherSubscription.Models;
using RJL.UIP.CPro.HW3.WeatherSubscription.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW3.WeatherSubscription
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherRequester weatherKyiv = new WeatherRequester("0867b08df07d2f5a09b6db1f31a7fffb", "Kyiv");
            WeatherRequester weatherLviv = new WeatherRequester("0867b08df07d2f5a09b6db1f31a7fffb", "Lviv");

            WeatherHandler weatherForecastKyiv = new WeatherHandler();
            WeatherHandler weatherForecastLviv = new WeatherHandler();

            FileStorage file = new FileStorage(@"c:\temp\weather.txt");
            ConsoleStorage console = new ConsoleStorage();

            weatherForecastKyiv.Subscribe(file);
            weatherForecastKyiv.Subscribe(console);
            IDisposable unsubWeatherForecastKyiv = weatherForecastKyiv.Subscribe(file);
            IDisposable unsubWeatherForecastKyiv2 = weatherForecastKyiv.Subscribe(console);

            weatherForecastLviv.Subscribe(file);
            weatherForecastLviv.Subscribe(console);

            IDisposable unsubWeatherForecastLviv = weatherForecastKyiv.Subscribe(file);
            IDisposable unsubWeatherForecastLviv2 = weatherForecastKyiv.Subscribe(console);

            for (int i = 0; i < 10; i++)
            {
                weatherForecastKyiv.ChangeForecast(weatherKyiv.GetForecast());
                weatherForecastLviv.ChangeForecast(weatherLviv.GetForecast());
                unsubWeatherForecastKyiv.Dispose();
                unsubWeatherForecastKyiv2.Dispose();
            }

            Console.ReadLine();
        }
    }
}
