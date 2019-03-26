using RJL.UIP.CPro.HW2.Vehicle.Models;
using RJL.UIP.CPro.HW2.Vehicle.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW2.Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuiItems = new string[] { "quit",
                "create new vehicle",
                "show all vehicles in list",
                "show max speed vehicle",
                "show the newest vehicle",
                "show the oldest vehicle",

                "clear console" };
            int indexCommand;
            
            CCar Car1 = new CCar(new GPS(1,1), 10, 2018);
            CPlane Plane1 = new CPlane(new GPS(2, 2), 100, 2015,"100 m", 200);
            CPlane Plane2 = new CPlane(new GPS(2, 2), 200, 2015, "200 m", 300);
            CShip Ship1 = new CShip(new GPS(3, 3), 250, 2014, 50, "PortName");
            CShip Ship2 = new CShip(new GPS(4, 4), 150, 2013, 20, "PortName2");



            do
            {
                indexCommand = UserConsoleInteractor.GetCommandFromOptionMenu(menuiItems);
                UserConsoleInteractor.ChooseOptionMenu(indexCommand);
            } while (indexCommand != 0);

            Console.ReadLine();
        }
    }
}
