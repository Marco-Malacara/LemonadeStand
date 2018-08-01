using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   abstract class Store
    {
        double buyCups;
        double buyLemons;
        double BuySugar;
        double BuyIce;
        Lemon lemon = new Lemon();
        public Store()
        {
            
        }

        // member methods (CAN DO)
        public void BuyItems()
        {
            Console.WriteLine("Press [1] to buy Lemons.");
            Console.WriteLine("Press [2] to buy Cups.");
            Console.WriteLine("Press [3] to buy Sugar.");
            Console.WriteLine("Press [4[ to buy Ice.");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    GetLemons(player);
                    break;
            }
        }
        public double AmountOfLemonsNeeded(Player player)
        {
            Console.WriteLine("Lemons are $0.15 each.");
            Console.WriteLine("How many Lemons would you like to buy?");

            double lemonsNeeded = double.Parse(Console.ReadLine());
            return lemonsNeeded;
        }

        public double PurchasedLemons(double lemonsNeeded)
        {
            buyLemons = lemon.GetCost() * lemonsNeeded;
            return buyLemons;
        }

        public void PayForLemons(Player player)
        {

        }
    }
}
