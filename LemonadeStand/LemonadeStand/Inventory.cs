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
        List<Lemon> lemons = new List<Lemon>();
        List<Sugar> sugar = new List<Sugar>();
        List<Cup> cups = new List<Cup>();
        List<Ice> ice = new List<Ice>();

        public Inventory()
        {

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
        }

        public void UseLemons(Player player)
        {
            int lemonsToRemove = player.recipe.RemoveLemonsFromInventory();
            for (int i = 0; i < lemonsToRemove; i++)
            {
                lemons.RemoveAt(0);
            }
        }

        public void AddSugar(int AmountOfSugarNeeded)
        {
            for (int i = 0; i < AmountOfSugarNeeded; i++)
            {
                Sugar sugar = new Sugar();
                this.sugar.Add(sugar);
            }
            Console.WriteLine("You currently have {0} cups of sugar.", sugar.Count);
        }

        public void AddCups(int AmountOfCupsNeeded)
        {
            for (int i = 0; i < AmountOfCupsNeeded; i++)
            {
                Cup cups = new Cup();
                this.cups.Add(cups);
            }
            Console.WriteLine("You currently have {0} cups.", cups.Count);
        }

        public void AddIce(int AmountOfIceNeeded)
        {
            for (int i = 0; i < AmountOfIceNeeded; i++)
            {
                Ice ice = new Ice();
                this.ice.Add(ice);
            }
            Console.WriteLine("You currently have {0} cups.", ice.Count);
        }

        public void DisplayInventory()
        {
            Console.WriteLine("You currently have {0} lemons.", lemons.Count);
            Console.WriteLine("You currently have {0} cups of sugar.", sugar.Count);
            Console.WriteLine("You currently have {0} cups.", cups.Count);
            Console.WriteLine("You currently have {0} ice cubes.", ice.Count);
        }
    }
}
