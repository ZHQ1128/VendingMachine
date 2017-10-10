using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineAssignment.Models
{
    class Meny
    {
        public static void startMeny()
        {
            Inventory inven = new Inventory();
            int userInput = 0;
            //User person = new User(20);

            do
            {
                Console.Clear();
                Console.WriteLine("1.Show Menu ");
                Console.WriteLine("2.Buy Snacks ");
                Console.WriteLine("3.Buy Drinks ");
                Console.WriteLine("4.Checkout ");
                Console.WriteLine("5.Show Balance ");
                Console.WriteLine("6.Quit");
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        inven.ShowMenu();
                        Console.WriteLine("Press Any Key to continue:");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("What Snack do you want to buy?");
                        string snackName = Console.ReadLine().ToLower();
                        Console.WriteLine("call BuySnacks method");
                        inven.BuySnacks(snackName);
                        Console.ReadKey();

                        break;
                    case 3:
                        Console.WriteLine("What beverage do you want to buy?");
                        string drinkName = Console.ReadLine().ToLower();
                        Console.WriteLine("What size do you want to choose? (Small = 1, Medium = 2, Large = 3)");
                        int size = Convert.ToInt32(Console.ReadLine());
                        //var obj = Inventory.BeverageList.FirstOrDefault(x => x.Name.ToLower() == drinkName);
                        //Console.WriteLine(obj.Price);
                        inven.BuyDrinks(drinkName, size);
                        Console.ReadKey();
                        break;

                    case 4:

                        break;
                    case 5:
                        inven.CheckOut();
                        break;

                }

            } while (userInput != 6);


        }
    }
}
