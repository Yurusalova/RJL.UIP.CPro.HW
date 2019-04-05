using RJL.UIP.CPro.HW4.WeatherStatistic.Interfaces;
using RJL.UIP.CPro.HW4.WeatherStatistic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW4.WeatherStatistic.Models
{
    class WeatherList: IWeatherList
    {

        private Weather[] mas;
        private int top;
        public WeatherList()
        {
            mas = new Weather[1];
            top = -1;
        }
        public WeatherList(int n)
        {
            mas = new Weather[n];
            top = -1;

        }
        public Weather Pop()
        {
            if (!IsEmpty())
            {
                Weather v = mas[top];
                mas[top] = null;
                top--;
                return v;
            }
            else
            {
                return null;
            }
        }
        private void EnsureCapacity()
        {
            Weather[] temp = new Weather[mas.Length * 2];
            Array.Copy(mas, temp, mas.Length);
            mas = temp;
        }
        public void Push(Weather v)
        {
            if (IsFull())
            {
                EnsureCapacity();
            }
            mas[++top] = v;
        }
        public Weather Peek()
        {
            return mas[top];
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
        public bool IsFull()
        {
            return top == mas.Length - 1;
        }
        public int Count()
        {
            return top + 1;
        }
        public void Print()
        {
            foreach (var item in mas)
            {
                Console.WriteLine(item + ", ");
            }
        }

        public Weather GetMaxTemperatureWeather()
        {
            Weather weatherMaxTemp = new Weather();
            weatherMaxTemp = mas[0];

            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] != null && weatherMaxTemp.Temperature < mas[i].Temperature)
                {

                    weatherMaxTemp = mas[i];
                }
                else { continue; }
            }
          
            return weatherMaxTemp;
        }
        public Weather GetMinTemperatureWeather()
        {
            Weather weatherMinTemp = new Weather();
            weatherMinTemp = mas[0];

            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] != null && weatherMinTemp.Temperature > mas[i].Temperature)
                {

                    weatherMinTemp = mas[i];
                }
                else {
                    continue;
                }
            }

            return weatherMinTemp;
        }

        public Weather GetMaxWindSpeedWeather()
        {
            Weather weatherMaxWindSpeed = new Weather();
            weatherMaxWindSpeed = mas[0];

            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] != null && weatherMaxWindSpeed.WindSpeed < mas[i].WindSpeed)
                {

                    weatherMaxWindSpeed = mas[i];
                }
                else { continue; }
            }

            return weatherMaxWindSpeed;
        }
        public Weather GetMinWindSpeedWeather()
        {
            Weather weatherMinWindSpeed = new Weather();
            weatherMinWindSpeed = mas[0];

            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] != null && weatherMinWindSpeed.WindSpeed > mas[i].WindSpeed)
                {

                    weatherMinWindSpeed = mas[i];
                }
                else
                {
                    continue;
                }
            }

            return weatherMinWindSpeed;
        }

        public Weather GetMaxPressureWeather()
        {
            Weather weatherMaxPressure = new Weather();
            weatherMaxPressure = mas[0];

            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] != null && weatherMaxPressure.Pressure < mas[i].Pressure)
                {

                    weatherMaxPressure = mas[i];
                }
                else { continue; }
            }

            return weatherMaxPressure;
        }
        public Weather GetMinPressureWeather()
        {
            Weather weatherMinPressure = new Weather();
            weatherMinPressure = mas[0];

            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] != null && weatherMinPressure.Pressure > mas[i].Pressure)
                {

                    weatherMinPressure = mas[i];
                }
                else
                {
                    continue;
                }
            }

            return weatherMinPressure;
        }
    }
}

