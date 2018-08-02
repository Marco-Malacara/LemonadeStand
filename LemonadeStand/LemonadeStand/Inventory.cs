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
        List<Sugar> sugar;
        List<Cup> cups;
        List<Ice> ice;


        public Inventory()
        {
            lemons = new List<Lemon>();
            sugar = new List<Sugar>();
            cups = new List<Cup>();
            ice = new List<Ice>();
        }

        // member methods (CAN DO)
        public void AddLemons(double AmountOfLemonsNeeded)
        {
            for(double i = 0; i < AmountOfLemonsNeeded; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
            Console.WriteLine("You currently have {0} lemons.", lemons.Count);
            Console.ReadLine();
        }

        public void AddSugar(double AmountOfSugarNeeded)
        {
            for (double i = 0; i < AmountOfSugarNeeded; i++)
            {
                Sugar sugar = new Sugar();
                this.sugar.Add(sugar);
            }
            Console.WriteLine("You currently have {0} cups of sugar.", sugar.Count);
            Console.ReadLine();
        }

        public void AddCups(double AmountOfCupsNeeded)
        {
            for (double i = 0; i < AmountOfCupsNeeded; i++)
            {
                Cup cups = new Cup();
                this.cups.Add(cups);
            }
            Console.WriteLine("You currently have {0} cups.", cups.Count);
            Console.ReadLine();
        }

        public void AddIce(double AmountOfIceNeeded)
        {
            for (double i = 0; i < AmountOfIceNeeded; i++)
            {
                Ice ice = new Ice();
                this.ice.Add(ice);
            }
            Console.WriteLine("You currently have {0} cups.", ice.Count);
            Console.ReadLine();
        }

        public void DisplayCurrentInventory()
        {
            Console.WriteLine("You currently have {0} lemons.", lemons.Count);
            Console.WriteLine("You currently have {0} cups of sugar.", sugar.Count);
            Console.WriteLine("You currently have {0} cups.", cups.Count);
            Console.WriteLine("You currently have {0} ice cubes.", ice.Count);
        }
    }
}
