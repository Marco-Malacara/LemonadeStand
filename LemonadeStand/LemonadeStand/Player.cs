using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        private Inventory inventory;
        private Cash cash;

    public Player()
        {
            inventory = new Inventory();
            cash = new Cash();
        }
    }
}
