using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // memeber variables (HAS A)
        // has items
        // has item counter
        public Lemon lemon;


        public Inventory()
        {
           lemon = new Lemon();
        }

        // member methods (CAN DO)
       
        public void DisplayInventory()
        {
            Console.WriteLine("You have " + lemon.amount + " lemon(s).");
        }
    }
}
