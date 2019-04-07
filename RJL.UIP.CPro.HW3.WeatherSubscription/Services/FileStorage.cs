using RJL.UIP.CPro.HW3.WeatherSubscription.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW3.WeatherSubscription.Services
{
    class FileStorage : IObserver<WeatherForecast>
    {
        public string Path { get; private set; }
      
        public FileStorage(string path) {
            this.Path = path;
        }

        public void OnCompleted()
        {
            StreamWriter sw = new StreamWriter(this.Path, true);
            sw.WriteLine("Complete" + DateTime.Now);
            sw.Close();
        }

        public void OnError(Exception error)
        {

            StreamWriter sw = new StreamWriter(this.Path, true);
            sw.WriteLine("Error" + DateTime.Now);
            sw.Close();
        }

        public void OnNext(WeatherForecast value)
        {
            StreamWriter sw = new StreamWriter(this.Path, true);
            sw.WriteLine(value);
            Console.WriteLine("File" + value);
            sw.Close();
        }
    }
}
