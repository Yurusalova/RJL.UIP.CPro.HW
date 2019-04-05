using RJL.UIP.CPro.HW4.WeatherStatistic.Interfaces;
using RJL.UIP.CPro.HW4.WeatherStatistic.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW4.WeatherStatistic.Services
{
    class WeatherHandler
    {
        public static void GetWeatherFromFile( IWeatherList weatherCurrentList, string filename)
        {
            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(filename);
            DateTime dateFile = DateTime.ParseExact(fileNameWithoutExt, "yyyyMMdd", CultureInfo.InvariantCulture);
          
            using (StreamReader sr = new StreamReader(filename))
               
            {
                while (!sr.EndOfStream)
                {
                    Weather weatherItem = new Weather();

                    string strparams = sr.ReadLine();
                    string[] p = strparams.Split('=', ';');
                    if (p[0].Contains("City"))
                    {
                        weatherItem.City = p[1];

                    }
                    if (p[2].Contains("Temperature"))
                    {
                        weatherItem.Temperature = double.Parse(p[3]);

                    }
                    if (p[4].Contains("WindSpeed"))
                    {
                        weatherItem.WindSpeed = double.Parse(p[5]);

                    }
                    if (p[6].Contains("Pressure"))
                    {
                        weatherItem.Pressure = double.Parse(p[7]);

                    }
                    weatherItem.DTime = dateFile;
                    weatherCurrentList.Push(weatherItem);
                }
            }

        }

        
}
}
