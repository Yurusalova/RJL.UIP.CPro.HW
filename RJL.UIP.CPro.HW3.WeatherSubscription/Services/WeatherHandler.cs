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
            if (!Observers.Contains(observer))
                Observers.Add(observer);

            return new Unsubscriber(Observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeatherForecast>> _observers;
            private IObserver<WeatherForecast> _observer;

            public Unsubscriber(List<IObserver<WeatherForecast>> observers, IObserver<WeatherForecast> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }
            public void Dispose()
            {
                if (!(_observer == null)|| _observers.Contains(_observer)) _observers.Remove(_observer);
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