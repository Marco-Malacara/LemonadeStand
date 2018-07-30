using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Player
    {
        // memeber variables (HAS A)
        // Has a name
        // Has a money
        protected string name;
        protected double availabeMoney;
        protected double spendMoney;

        public Player()
        {
            name = "Jarvis";
            availabeMoney = 0;
        }

        // member methods (CAN DO)
        // can get name
        // can track money
        protected virtual void GetPlayerName()
        {

        }

        protected void TotalMoney()
        {
            Console.WriteLine("You currently have $" + availabeMoney);
        }

        protected void AddMoney()
        {

        }

        protected void SubtractMoney()
        {
            spendMoney = (availabeMoney - spendMoney);
            TotalMoney();
        }
    }
}
