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
        List<Lemon> lemons;
        


        public Inventory()
        {
            lemons = new List<Lemon>();
        }

        // member methods (CAN DO)
        public void AddLemons(int AmountOfLemonsNeeded)
        {
            for(int i = 0; i < AmountOfLemonsNeeded; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
            Console.WriteLine("You currently have {0} lemons.", lemons.Count);
            Console.ReadLine();
        }
    }
}
