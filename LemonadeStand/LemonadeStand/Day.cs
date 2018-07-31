﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // memeber variables (HAS A)
        Weather todaysWeather;

        public Day()
        {
            todaysWeather = new Weather();
        }

        // member methods (CAN DO)
        private void GetTodaysWeather()
        {
            todaysWeather.GetTempature();
            todaysWeather.GetWeatherConditions();
            Console.WriteLine("Today's weather is " + todaysWeather.tempature + "° and " + todaysWeather.todaysConditions);
        }
    }
}