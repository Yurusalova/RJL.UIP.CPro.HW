using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW4.WeatherStatistic.Models
{
        class Weather
        {
            public double Temperature { get; set; }
            public double WindSpeed { get; set; }
            public double Pressure { get; set; }
            public DateTime DTime { get; set; }
            public string City { get; set; }

            public override string ToString()
            {
                return $"{DTime.ToString("yyyy-MM-dd")}: City={City}, Temperature={Temperature}, WindSpeed={WindSpeed}, Pressure={Pressure}";
            }
        }
    }
