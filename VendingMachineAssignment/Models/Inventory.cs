using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineAssignment.Models
{
    class Inventory
    {
        public static List <Snack> SnackList { get; set; }
        public static List<Beverage> BeverageList { get; set; }
        public List <int> priceList = new List<int>();

        public Inventory()
        {
            BeverageList = new List<Beverage>();

            Beverage cocaCola = new Beverage("CocaCola", 2, 3, 4);
            Beverage fanta = new Beverage("Fanta", 2, 3, 4);
            Beverage coffee = new Beverage("Coffee", 1, 2, 3);
            Beverage tea = new Beverage("Tea", 1, 2, 3);
            Beverage beer = new Beverage("Beer", 4, 5, 6);
            BeverageList.Add(cocaCola);
            BeverageList.Add(fanta);
            BeverageList.Add(coffee);
            BeverageList.Add(tea);
            BeverageList.Add(beer);

            SnackList = new List<Snack>();

            Snack chips = new Snack("Chips", 2);
            Snack kex = new Snack("Kex", 3);
            Snack kitkat = new Snack("Kitkat", 4);
            Snack nuts = new Snack("Nuts", 2);
            Snack energyBar = new Snack("EnergyBar", 3);
            SnackList.Add(chips);
            SnackList.Add(kex);
            SnackList.Add(kitkat);
            SnackList.Add(kitkat);
            SnackList.Add(kitkat);
        }

        //public void Total() { }
        public void ShowMenu()
        {
            //foreach (MenyItem item in InventoryList)
            //{
            //    Console.WriteLine(item.PrintToScreen());
            //}
        }


        public void BuySnacks(string name)
        {
            var obj = SnackList.FirstOrDefault(x => x.Name.ToLower() == name);
            Console.WriteLine(obj);
            int price = obj.Price;
            priceList.Add(price);
        }

        public void BuyDrinks(string name, int size)
        {
            var obj = BeverageList.FirstOrDefault(x => x.Name.ToLower() == name);
            obj
            //Console.WriteLine(obj);
            int price = obj.Price;
            priceList.Add(price);

        }
        public void CheckOut()
        {

        }

    }
}
