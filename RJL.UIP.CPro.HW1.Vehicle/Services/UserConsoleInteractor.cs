using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW2.Vehicle.Services
{
    static class UserConsoleInteractor
    {
        public static int GetCommandFromOptionMenu(string[] menuItems)
        {
            Console.WriteLine("---------------------------NEW COMMAND----------------------------");
            Console.WriteLine("Please write the index of command from the list below. Commands:");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"[{i}] = {menuItems[i]}");
            }
            string inputResult = Console.ReadLine();
            int inputIntResult;
            bool isSuccessInput = int.TryParse(inputResult, out inputIntResult);
            return inputIntResult;
        }
        public static void ChooseOptionMenu(int inputIntResult)
        {
            switch (inputIntResult)
            {
                case 0:
                    Console.WriteLine("Good bye!");
                    break;
                case 1:
                    //AddStoreToShop(shop);
                    break;
                case 2:
                   // SelectStoreForAddPhones(shop);
                    break;
                case 3:
                    //AllStoresOutput(shop, true);
                    break;
                case 4:
                    Console.Clear();
                    break;
            }
        }
    }
}
