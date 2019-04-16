using RJL.UIP.CPro.HW5.BusStationBinaryTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW5.BusStationBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BusBinaryTree autoPark = new BusBinaryTree();
            Bus bus = new Bus(5, "Gasya", 115);
            autoPark.AddBusNode(new Bus(4, "Vasya", 111));
            autoPark.AddBusNode(new Bus(2, "Tasya", 112));
            autoPark.AddBusNode(new Bus(3, "Masya", 113));
            autoPark.AddBusNode(new Bus(1, "Dasya", 114));
            autoPark.AddBusNode(bus);
            autoPark.AddBusNode(new Bus(6, "Zasya", 116));
            autoPark.PrintBusBinaryTree();
            autoPark.DeleteBusNode(bus);
            autoPark.PrintBusBinaryTree();
            Console.ReadLine();
        }
    }
}
