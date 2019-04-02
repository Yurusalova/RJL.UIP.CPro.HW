using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW3.WeatherSubscription.Models
{
    class WeatherForecast
    {
        public string Temperature { get; set; }
        public string WindSpeed { get; set; }
        public string Pressure { get; set; }
        public DateTime DTime { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{DTime}: City={City}, Temperature={Temperature}, WindSpeed={WindSpeed}, Pressure={Pressure}";
        }
    }
}
