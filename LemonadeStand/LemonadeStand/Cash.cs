using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cash
    {
        public double moneyAvailable = 15.00;
        double purchaseItem;
        bool insufficantFunds;
        double cost;
        Store store = new Store();

        public Cash()
        {
            
        }

        public void DisplayCash()
        {
            Console.WriteLine(moneyAvailable);
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
            purchaseItem = moneyAvailable - cost;
            Console.WriteLine("Your purchase was succesful sending the items to your inventory now!");
            moneyAvailable = purchaseItem;
            return moneyAvailable;
        }
    }
}
