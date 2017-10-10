using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineAssignment.Models
{
    class Snack : MenyItem
    {

        public int Price { get; set; }


        public Snack(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }


        public override string PrintToScreen()
        {
            return base.PrintToScreen() + $"Price: {Price}\n";
        }

    }

}
