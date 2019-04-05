using RJL.UIP.CPro.HW4.WeatherStatistic.Interfaces;
using RJL.UIP.CPro.HW4.WeatherStatistic.Models;
using RJL.UIP.CPro.HW4.WeatherStatistic.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW4.WeatherStatistic
{
    class Program
    {
        static void Main(string[] args)
        {

            string pathToFiles = @"C:\Temp\";
            string[] filesList = Directory.GetFiles(pathToFiles);
            Console.WriteLine("--------------Loading list of files from directory " + pathToFiles);
            foreach (var item in filesList)
            {
                Console.WriteLine(item);
            }
            IWeatherList weatherCurrentList = new WeatherList();

            
            Console.WriteLine("--------------Loading data from all files in directory " + pathToFiles);
            foreach (var item in filesList)
            {
                WeatherHandler.GetWeatherFromFile(weatherCurrentList, item);
            }
            Console.WriteLine("--------------------------------------------------");
            weatherCurrentList?.Print();
            Console.WriteLine("-----------Weather with max temp-------");
            Console.WriteLine(weatherCurrentList.GetMaxTemperatureWeather());
            Console.WriteLine("-----------Weather with min temp-------");
            Console.WriteLine(weatherCurrentList.GetMinTemperatureWeather());
            Console.WriteLine("-----------Weather with max wind speed-------");
            Console.WriteLine(weatherCurrentList.GetMaxWindSpeedWeather());
            Console.WriteLine("-----------Weather with min wind Speed-------");
            Console.WriteLine(weatherCurrentList.GetMinWindSpeedWeather());
            Console.WriteLine("-----------Weather with max pressure-------");
            Console.WriteLine(weatherCurrentList.GetMaxPressureWeather());
            Console.WriteLine("-----------Weather with min pressure-------");
            Console.WriteLine(weatherCurrentList.GetMinPressureWeather());
            Console.ReadLine();
        }
    }
}
