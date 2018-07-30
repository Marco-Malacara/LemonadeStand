using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        // memeber variables (HAS A)
        // has items
        // has a item cost
        string choice;


        public Store()
        {
            
        }

        // member methods (CAN DO)
        public void BuyItems(List<string> items)
        {
            for(int i = 0; i <items.Count; i++)
            {
                Console.WriteLine("Press " + (i + 1) + " to buy " + items[i] + ".");
            }
            int userInput = Int32.Parse(Console.ReadLine());
            choice = items[userInput - 1];

            Console.ReadLine();
        }
    }
}
