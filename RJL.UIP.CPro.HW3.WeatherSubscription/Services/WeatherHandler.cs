using RJL.UIP.CPro.HW3.WeatherSubscription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW3.WeatherSubscription.Services
{
    class WeatherHandler : IObservable<WeatherForecast>
    {
       
        public IDisposable Subscribe(IObserver<WeatherForecast> observer)
        {
            throw new NotImplementedException();
        }

       
        

    }
}