using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // memeber variables (HAS A)
        // Has a menu
        // Has players
        // Has a set of rules
        // number of days
        private Player player;
        private Store store;
        private Day day;
        

        public Game()
        {
            player = new Player();
            store = new Store();
            day = new Day();
        }

        public void RunGame()
        {
            //create customer function
            UserInterFace.DisplayWelcomeMessage();
            MakeWeather();
            MainMenu();
            // start day
        }

        public void MakeWeather()
        {
            day.weather.GenerateTodaysWeather();
            day.weather.GenerateForecast();
        }

        public void MainMenu()
        {
            Console.WriteLine("Please choose from one of the option below!");
            Console.WriteLine("1: Rules");
            Console.WriteLine("2: Weather");
            Console.WriteLine("3: Check available money");
            Console.WriteLine("4: Head to store!");
            Console.WriteLine("5: Check inventory!");
            Console.WriteLine("6: Check recipe and make Lemonade!");
            Console.WriteLine("7: Set Price and play game!");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    UserInterFace.DisplayRules();
                    Console.WriteLine("Press [enter] to return to main menu.");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                case "2":
                    Console.Clear();
                    day.weather.DisplayTodaysWeather();
                    day.weather.GenerateForecast();
                    Console.WriteLine("Press [enter] to return to main menu.");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                case "3":
                    Console.Clear();
                    player.cash.DisplayCash();
                    Console.WriteLine("Press [enter] to return to main menu.");
                    Console.ReadLine();
                    MainMenu();
                    break;
                case "4":
                    Console.Clear();
                    player.cash.DisplayCash();
                    player.inventory.DisplayInventory();
                    store.Restock(player);
                    Console.WriteLine("Press [enter] to return to main menu.");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                case "5":
                    Console.Clear();
                    player.inventory.DisplayInventory();
                    Console.WriteLine("Press [enter] to return to main menu.");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                    break;
                case "6":
                    Console.Clear();
                    player.inventory.DisplayInventory();
                    player.recipe.ChooseRecipe();
                    break;
                case "7":
                    // create ability to set price of cups
                    break;
                default:
                    Console.WriteLine("That input was not valid please try again!");
                    MainMenu();
                    break;

            }
        }
        
    }
}
