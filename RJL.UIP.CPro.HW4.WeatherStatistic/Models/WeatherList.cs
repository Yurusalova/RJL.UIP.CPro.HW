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
            mas = new Weather[10];
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
    }
}
