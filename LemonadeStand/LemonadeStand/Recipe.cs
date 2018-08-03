using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        public int numberOfPitchers;
        int lemonsForRecipe;
        int sugarForRecipe;
        int cupsForRecipe;
        int iceForRecipe;

        public Recipe()
        {
            lemonsForRecipe = 4;
            sugarForRecipe = 4;
            cupsForRecipe = 10;
            iceForRecipe = 4;
        }

        public void ChooseRecipe()
        {
            Console.WriteLine("The standard recipe for lemonade is 4 lemons, 4 cups of sugar, and 4 icecubes");
            Console.WriteLine("Press [1] to use the standard recipe other wise, Press [2] to make your own recipe!");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    NumberOfPitchersToBeMade();
                    DisplayRecipe();
                    break;
                case "2":
                    CustomLemons();
                    CustomSugar();
                    CustomIce();
                    DisplayRecipe();
                    NumberOfPitchersToBeMade();
                    break;
                default:
                    Console.WriteLine("That input is invalid please try again!");
                    return;
            }
        }
        
        public int NumberOfPitchersToBeMade()
        {
            Console.WriteLine("Time to make some lemonade! Don't forget!");
            Console.WriteLine("The amount of lemonade you have the potential to sell if based off weather and price!");
            Console.WriteLine("ALL unused lemonade will be discarded after each day!");
            Console.WriteLine("Now down to buisness! How many pitchers would you like to make!");

            int numberOfPitchers = int.Parse(Console.ReadLine());
            this.numberOfPitchers = numberOfPitchers;
            return this.numberOfPitchers;
        }

        public int CustomLemons()
        {
            Console.WriteLine("Gonna make your own recipe ey? Well alright!");
            Console.WriteLine("How many lemons would you like to add?");

            int numberOfLemons = int.Parse(Console.ReadLine());
            numberOfLemons = lemonsForRecipe;
            return lemonsForRecipe;
        }

        public int CustomSugar()
        {
            Console.WriteLine("How many cups of sugar would you like to add?");

            int amountOfSugar = int.Parse(Console.ReadLine());
            amountOfSugar = sugarForRecipe;
            return sugarForRecipe;
        }

        public int CustomIce()
        {
            Console.WriteLine("How many ice cubes do you want in each cup?");

            int numberOfIceCubes = int.Parse(Console.ReadLine());
            numberOfIceCubes = iceForRecipe;
            return iceForRecipe;
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("You've decided to go with {0} lemons, {1} sugar, {2} ice cubes each pitcher makes {3} cups!", lemonsForRecipe, sugarForRecipe, iceForRecipe, cupsForRecipe);
        }
    }
}
    