﻿using RJL.UIP.CPro.HW4.WeatherStatistic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW4.WeatherStatistic.Interfaces
{
    interface IWeatherList
    {
        void Push(Weather v);
        void Print();
    }
}