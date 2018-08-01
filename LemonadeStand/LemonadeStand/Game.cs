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
        }

        // member methods (CAN DO)
        public void RunGame()
        {
            store.Restock(player);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
