using RJL.UIP.CPro.HW4.WeatherStatistic.Interfaces;
using RJL.UIP.CPro.HW4.WeatherStatistic.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW4.WeatherStatistic.Services
{
    class WeatherHandler
    {
        public static void GetWeatherFromFile(out IWeatherList weatherCurrentList, string filename)
        {
            weatherCurrentList = new WeatherList();
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    Weather weatherItem = new Weather();
                    //int type = int.Parse(sr.ReadLine());
                    string strparams = sr.ReadLine();
                    string[] p = strparams.Split('=',';');
                    if (p[1].Contains("Temperature"))
                    {
                        weatherItem.Temperature = p[2];
                        
                    }
                    if (p[3].Contains("WindSpeed"))
                    {
                        weatherItem.WindSpeed = p[4];

                    }
                    if (p[5].Contains("Pressure"))
                    {
                        weatherItem.Pressure = p[6];

                    }
                    weatherCurrentList.Push(weatherItem);
                }
            }
        }
    }
}
