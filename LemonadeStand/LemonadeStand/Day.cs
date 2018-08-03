using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Random random;
        public Weather weather;
        public double pricePerCup;
        public double willingToPay;
        public int cupsToSell;
        List<double> costCustomersWillPay = new List<double> { .25, 1.00, .75, .90, 1.25 };
        List<int> cupsCustomersWillBuy = new List<int> { 1, 3, 1, 4, 1 };

        public Day()
        {
            weather = new Weather();
            random = new Random();
        }

        public double PricePerCup()
        {
            Console.WriteLine("How much would you like to sell your lemonade for?");
            double pricePerCup = double.Parse(Console.ReadLine());
            this.pricePerCup = pricePerCup;
            return this.pricePerCup;
        }
        
        public double PayingCustomer()
        {
            int customersWillingToPay = random.Next(0, costCustomersWillPay.Count);
            willingToPay = costCustomersWillPay[customersWillingToPay];
            return willingToPay;
        }

        public int CustomerWillingToBuy()
        {
            int howMuchWillPlayerSell = random.Next(0, cupsCustomersWillBuy.Count);
            cupsToSell = cupsCustomersWillBuy[howMuchWillPlayerSell];
            return cupsToSell;
        }

        
    }
}
