using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW2.Vehicle.Models
{
    class CShip:CVehicle
    {
        public int CountPassenger { get; set; }
        public string HomePort { get; set; }

        public CShip(GPS gps, double price, int yearProduction, int countPassenger, string homePort) : base(gps, price, yearProduction)
        {
            CountPassenger = countPassenger;
            HomePort = homePort;
        }
    }
}
