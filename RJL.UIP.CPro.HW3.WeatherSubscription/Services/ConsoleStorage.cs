using RJL.UIP.CPro.HW3.WeatherSubscription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW3.WeatherSubscription.Services
{
    class ConsoleStorage : IObserver<WeatherForecast>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Completed");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error" + error+ DateTime.Now);
        }

        public void OnNext(WeatherForecast value)
        {
            Console.WriteLine("Console "+value);
        }
    }
}
