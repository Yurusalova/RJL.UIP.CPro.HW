using RJL.UIP.CPro.HW4.WeatherStatistic.Interfaces;
using RJL.UIP.CPro.HW4.WeatherStatistic.Models;
using RJL.UIP.CPro.HW4.WeatherStatistic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW4.WeatherStatistic
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeatherList weatherCurrentList;
            IWeatherList pass = new WeatherList();
            IWeatherList cargo = new WeatherList();

            WeatherHandler.GetWeatherFromFile(out weatherCurrentList, @"C:\Temp\20190403.txt");
            weatherCurrentList.Print();
            Console.ReadLine();
        }
    }
}
