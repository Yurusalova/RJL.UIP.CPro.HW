﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW5.BusStationBinaryTree.Models
{
    class Bus
    {
        public Bus(int id, string name, int route)
        {
            Id = id;
            Name = name;
            Route = route;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Route { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Route}";
        }
    }
}
