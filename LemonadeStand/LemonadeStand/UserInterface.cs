using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterFace
    {

        public static void DisplayWelcomeMessage()
        { 
            Console.WriteLine("Welcome to Lemonade stand!");
            Console.WriteLine("You have come up with a crazy scheme to run a lemonade stand to make as much money possible in a week!");
            Console.WriteLine("You only have $25.00 to start your operation!");
            Console.WriteLine("Press [enter] to start the game!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplayRules()
        {
            Console.WriteLine("Alright buckle up cause here are the rules!");
            Console.WriteLine("You start with $25.00!");
            Console.WriteLine("Your goal is to make the greatest lemonade known to man!");
            Console.WriteLine("Manage your inventory wisley make sure you have enough items to make your lemonade!");
            Console.WriteLine("The amount of cups sold each day is based on the weather conditions and the price of your lemonade!");
            Console.WriteLine("You're goal is to make more then what you started with ($15.00) good luck and have fun!");
        }
    }
}
