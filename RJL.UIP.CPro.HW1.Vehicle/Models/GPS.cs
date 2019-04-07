using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW2.Vehicle.Models
{
    class GPS
    {
        public int Lat { get; set; }
        public int Lon { get; set; }

        public GPS(int lat, int lon) {
            this.Lat = lat;
            this.Lon = lon;
        }

        public override string ToString()
        {
            return $"{Lat}, {Lon}";
        }

    }
}
