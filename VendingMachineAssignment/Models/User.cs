using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineAssignment.Models
{
    class User
    {
        //public string Name { get; set; }
        private int Wallet { get; set; }


        public User(int wallet)
        {
            this.Wallet = wallet;
        }

        public void SpendMoney(int money)
        {
            Wallet -= money;
        }

        public void Balance()
        {
            Console.WriteLine($"{Wallet} dollars left");
        }


    }
}
