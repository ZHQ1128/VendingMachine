using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineAssignment.Models
{
    class MenyItem
    {
        public string Name { get; set; }

        public MenyItem() { }

        public virtual string PrintToScreen()
        {
            string print = $"{Name}\n";

            return print;
        }

    }
}
