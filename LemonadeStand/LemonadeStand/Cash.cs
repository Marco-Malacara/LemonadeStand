﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cash
    {
        public double startingAmount = 25.00;
        public double moneyAvailable;
        double remainingMoney;
        bool insufficantFunds;
        double cost;
        Store store = new Store();

        public Cash()
        {
            moneyAvailable = startingAmount;
        }

        public void DisplayCash()
        {
            Console.WriteLine("You currently have $" + moneyAvailable + ".");
        }

        public bool CheckIfSufficantFunds(double cost)
        {
            if(moneyAvailable < cost)
            {
                insufficantFunds = true;
                Console.WriteLine("Sorry you have insufficant funds for this purchase!");
            }
            return insufficantFunds;
        }

        public double BuyItem(double cost)
        {
            remainingMoney = moneyAvailable - cost;
            Console.WriteLine("Your purchase was succesful sending the items to your inventory now!");
            moneyAvailable = remainingMoney;
            return moneyAvailable;
        }
    }
}
