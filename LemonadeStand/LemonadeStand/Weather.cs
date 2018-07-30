using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        private List<string> weather;
        public string todaysConditions;
        public int tempature;
        Random random = new Random();

        public Weather()
        {
            weather = new List<string>() { "sunny", "raining", "cloudy", };
        }

        public void GetTempature()
        {
            tempature = random.Next(50, 100);
        }

        public void GetWeatherConditions()
        {
            todaysConditions = weather[random.Next(0, weather.Count)];
        }
    }
}
