using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW2.Vehicle.Models
{
    abstract class CVehicle
    {
        public GPS GPS { get; set; }
        public double Price { get; set; }
        public int YearProduction { get; set; }

        public CVehicle(GPS gps, double price, int yearProduction) {
            GPS = gps;
            Price = price;
            YearProduction = yearProduction;
        }
    }
}
