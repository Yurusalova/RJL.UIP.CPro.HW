using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW2.Vehicle.Models
{
    class CPlane : CVehicle
    {
        public string Height {get;set;}
        public int CountPassenger { get; set; }

        public CPlane(GPS gps, double price, int yearProduction, string height, int countPassenger) : base(gps, price, yearProduction) {
            Height = height;
            CountPassenger = countPassenger;
        }
    }
}
