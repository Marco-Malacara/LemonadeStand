using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemon
    {
        private double costOfLemons;

        public Lemon()
        {
            costOfLemons = .15;
        }

        public double GetCost()
        {
            return costOfLemons;
        }
    }
}
