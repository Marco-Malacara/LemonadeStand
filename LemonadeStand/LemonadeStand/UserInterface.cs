using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterFace
    {
        static void DisplayWelcomeMessage()
        {
            Day day = new Day();
            Game game = new Game();

            Console.WriteLine("Welcome to Lemonade stand!");
            Console.WriteLine("You have come up with a crazy scheme to run a lemonade stand to make as much money possible in a week!");
            Console.WriteLine("You only have $15.00 to start your operation!");
            Console.WriteLine("Press [enter] to start the game!");
            Console.ReadLine();
            Console.Clear();
            game.MakeWeather();
            game.MainMenu();
        }
    }
}
