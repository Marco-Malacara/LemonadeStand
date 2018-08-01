using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   class Store
    {
        double buyCups;
        double buyLemons;
        double buySugar;
        double buyIce;
        Lemon lemon = new Lemon();
        Sugar sugar = new Sugar();
        Cup cups = new Cup();
        Ice ice = new Ice();
        public Store()
        {
            
        }

        // member methods (CAN DO)
        public void Restock(Player player)
        {
            Console.WriteLine("Press [1] to buy Lemons.");
            Console.WriteLine("Press [2] to buy Sugar.");
            Console.WriteLine("Press [3] to buy Cups.");
            Console.WriteLine("Press [4[ to buy Ice.");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    GetLemons(player);
                        break;

                case "2":
                    GetSugar(player);
                        break;

                case "3":
                    GetCups(player);
                        break;

                case "4":
                    GetIce(player);
                        break;
                default:
                    Console.WriteLine("Sorry that input was invalid please try again!");
                    Restock(player);
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
            if (player.cash.CheckIfSufficantFunds(buyLemons))
            {
                Restock(player);
            }
            else
            {
                player.cash.BuyItem(buyLemons);
            }
        }

        public void GetLemons(Player player)
        {
            double numberOfLemons = AmountOfLemonsNeeded(player);
            PurchasedLemons(numberOfLemons);
            PayForLemons(player);
            player.inventory.AddLemons(numberOfLemons);
            Cash cash = new Cash();
            cash.DisplayCash();
            Restock(player);
        }

        public double AmountOfSugarNeeded(Player player)
        {
            Console.WriteLine("Sugar is $0.30 a cup.");
            Console.WriteLine("How many cups of sugar would you like to buy?");

            double cupsNeeded = double.Parse(Console.ReadLine());
            return cupsNeeded;
        }

        public double PurchasedSugar(double cupsNeeded)
        {
            buySugar = sugar.GetCost() * cupsNeeded;
            return buySugar;
        }

        public void PayForSugar(Player player)
        {
            if (player.cash.CheckIfSufficantFunds(buySugar))
            {
                Restock(player);
            }
            else
            {
                player.cash.BuyItem(buySugar);
            }
        }

        public void GetSugar(Player player)
        {
            double numberOfSugar = AmountOfSugarNeeded(player);
            PurchasedSugar(numberOfSugar);
            PayForSugar(player);
            player.inventory.AddSugar(numberOfSugar);
            Restock(player);
        }

        public double AmountOfCupsNeeded(Player player)
        {
            Console.WriteLine("Cups are $0.35 each.");
            Console.WriteLine("How many cups would you like to buy?");

            double drinkCupsNeeded = double.Parse(Console.ReadLine());
            return drinkCupsNeeded;
        }

        public double PurchasedCups(double cupsNeeded)
        {
            buyCups = cups.GetCost() * cupsNeeded;
            return buyCups;
        }

        public void PayForCups(Player player)
        {
            if (player.cash.CheckIfSufficantFunds(buyCups))
            {
                Restock(player);
            }
            else
            {
                player.cash.BuyItem(buyCups);
            }
        }

        public void GetCups(Player player)
        {
            double numberOfCups = AmountOfCupsNeeded(player);
            PurchasedCups(numberOfCups);
            PayForCups(player);
            player.inventory.AddCups(numberOfCups);
            Restock(player);
        }

        public double AmountOfIceNeeded(Player player)
        {
            Console.WriteLine("Ice is $0.10 each.");
            Console.WriteLine("How much ice would you like to buy?");

            double iceNeeded = double.Parse(Console.ReadLine());
            return iceNeeded;
        }

        public double PurchasedIce(double iceNeeded)
        {
            buyIce = ice.GetCost() * iceNeeded;
            return buyCups;
        }

        public void PayForIce(Player player)
        {
            if (player.cash.CheckIfSufficantFunds(buyIce))
            {
                Restock(player);
            }
            else
            {
                player.cash.BuyItem(buyIce);
            }
        }

        public void GetIce(Player player)
        {
            double amountOfIce = AmountOfIceNeeded(player);
            PurchasedIce(amountOfIce);
            PayForIce(player);
            player.inventory.AddIce(amountOfIce);
            Restock(player);
        }
    }
}
