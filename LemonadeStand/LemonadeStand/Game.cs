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
        Player playerOne;
        

        public Game()
        {
            playerOne = new Player();
        }

        // member methods (CAN DO)
        public void RunGame()
        {
            playerOne.ChooseItem(playerOne.items);
            playerOne.inventory.DisplayInventory();
        }
    }
}
