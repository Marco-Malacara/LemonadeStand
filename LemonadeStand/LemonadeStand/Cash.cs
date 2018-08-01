using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cash
    {
        public double moneyAvailable;
        double purchaseItem;
        Store store = new Store();

        public Cash()
        {
            moneyAvailable = 15.00;
        }

        public void CheckIfSufficantFunds()
        {
            if(moneyAvailable < store.costOfProduct)
            {
                Console.WriteLine("Sorry you have insufficant funds for this purchase!");
            }
        }

        public double BuyItem()
        {
            purchaseItem = moneyAvailable - store.costOfProduct;
            Console.WriteLine("Your purchase was succesful sending the items to your inventory now!");
            moneyAvailable = purchaseItem;
            return moneyAvailable;
        }
    }
}
