using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        private List<string> conditionOfWeather;
        private List<int> tempatureOfDay;
        public string conditions;
        public int tempature;
        Random random = new Random();

        public Weather()
        {
            conditionOfWeather = new List<string>() { "sunny", "raining", "cloudy", "partly cloudy" };
            tempatureOfDay = new List<int>() { 65, 70, 75, 80, 85, 90, 100 };
        }
        
        public void TodaysTemperature()
        {
            int todaysTemperature = random.Next(0, tempatureOfDay.Count);
            Console.WriteLine(tempature = tempatureOfDay[todaysTemperature]);
        }
    }
}
