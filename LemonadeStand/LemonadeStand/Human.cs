using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Human : Player
    {
        // memeber variables (HAS A)
        // gained through inharentence

        public Human()
        {

        }

        // member methods (CAN DO)
        protected override void GetPlayerName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
        }


    }
}
