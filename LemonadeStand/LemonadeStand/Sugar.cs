using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar
    {
        private double costOfSugar;

        public Sugar()
        {
            costOfSugar = .30;
        }

        public double GetCost()
        {
            return costOfSugar;
        }
    }
}
