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
        public List<IObserver<WeatherForecast>> Observers = new List<IObserver<WeatherForecast>>();

        private WeatherForecast weatherForecast;

        public IDisposable Subscribe(IObserver<WeatherForecast> observer)
        {
            this.Observers.Add(observer);
            return new Unsubscriber();
        }

        private class Unsubscriber : IDisposable
        {
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

        public void Notify()
        {
            foreach (var item in Observers)
            {
                item.OnNext(this.weatherForecast);
            }
        }

        public void ChangeForecast(WeatherForecast weatherForecast)
        {
            this.weatherForecast = weatherForecast;
            Notify();
        }


    }
}