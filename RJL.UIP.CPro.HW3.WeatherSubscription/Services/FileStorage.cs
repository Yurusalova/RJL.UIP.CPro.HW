using RJL.UIP.CPro.HW3.WeatherSubscription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW3.WeatherSubscription.Services
{
    class FileStorage : IObserver<WeatherForecast>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherForecast value)
        {
            throw new NotImplementedException();
        }
    }
}
