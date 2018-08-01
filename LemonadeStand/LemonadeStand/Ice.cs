using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Ice
    {
        private double costOfIce;

        public Ice()
        {
            costOfIce = .10;
        }

        public double GetCost()
        {
            return costOfIce;
        }
    }
}
