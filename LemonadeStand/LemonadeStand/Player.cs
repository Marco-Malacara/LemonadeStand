using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // memeber variables (HAS A)
        // Has a name
        // Has a money
        protected string name;
        public double availabeMoney;
        protected double spendMoney;
        public Inventory inventory;
        public List<string> items;
        string choice;
        

    public Player()
        {
            name = "Jarvis";
            availabeMoney = 20.00;
            inventory = new Inventory();
            items = new List<string>() { "Lemons", "Cups", "Sugar", "Ice" };
        }

        // member methods (CAN DO)
        // can get name
        // can track money
        protected virtual void GetPlayerName()
        {

        }

        public void TotalMoney()
        {
            Console.WriteLine("You currently have $" + availabeMoney);
            Console.ReadLine();
        }

        protected void AddMoney()
        {

        }

        public void ChooseItem(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("Press " + (i + 1) + " to buy " + items[i] + ".");
            }
            int userInput = Int32.Parse(Console.ReadLine());
            choice = items[userInput - 1];
            PurchaseItem();
        }
        public void PurchaseItem()
        {
            if (choice == "Lemons")
            {
                Console.WriteLine("How many lemons would you like to buy? Lemons are $0.15 each.");
                int userInput = int.Parse(Console.ReadLine());
                inventory.lemon.amount = userInput;
                availabeMoney = (availabeMoney - userInput * inventory.lemon.costOfLemons);
                inventory.DisplayInventory();
            }
            else if(choice == "Cups")
            {
                Console.WriteLine("How many lemons would you like to buy? Lemons are $0.15 each.");
                double userInput = double.Parse(Console.ReadLine());

                availabeMoney = (availabeMoney - userInput * inventory.lemon.costOfLemons);
            }
            else if(choice == "Sugar")
            {
                Console.WriteLine("How many lemons would you like to buy? Lemons are $0.15 each.");
                double userInput = double.Parse(Console.ReadLine());

                availabeMoney = (availabeMoney - userInput * inventory.lemon.costOfLemons);
            }
            else if(choice == "Ice")
            {
                Console.WriteLine("How many lemons would you like to buy? Lemons are $0.15 each.");
                double userInput = double.Parse(Console.ReadLine());

                availabeMoney = (availabeMoney - userInput * inventory.lemon.costOfLemons);
            }
            else
            {
                Console.WriteLine("Thats not a choice silly! Try again! :)");
            }
            ChooseItem(items);
            
        }
    }
}
