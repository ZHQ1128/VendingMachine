using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineAssignment.Models
{
    //Beverage should have 3 prices: small, medium and large sizes.
    //It should have a method named printToScreen.And you should implement the keyword override 
    //write a constructor that creates a beverage with all required properties including name and prices for small medium and large. 

    class Beverage : MenyItem
    {

        public int Small { get; set; }
        public int Medium { get; set; }
        public int Large { get; set; }


        public Beverage(string name, int small, int medium, int large)
        {
            this.Name = name;
            this.Small = small;
            this.Medium = medium;
            this.Large = large;
        }


        public override string PrintToScreen()
        {
            return base.PrintToScreen() + $"Small Size: {Small}\nMedium Size: {Medium}\nLarge Size: {Large}\n";
        }
    }
}