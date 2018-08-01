using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cup
    {
        private double costOfCups;

        public Cup()
        {
            costOfCups = .30;
        }

        public double GetCost()
        {
            return costOfCups;
        }
    }
}
