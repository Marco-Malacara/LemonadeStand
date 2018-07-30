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
        Store store;
        public List<string> items;

        public Game()
        {
            store = new Store();
            items = new List<string>() { "Lemons", "Cups", "Sugar", "Ice" };
        }

        // member methods (CAN DO)
        public void RunStore()
        {
            store.BuyItems(items);
        }
    }
}
