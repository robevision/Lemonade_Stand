using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        List<string> dayOne;
        List<string> dayTwo;
        List<string> dayThree;
        List<string> dayFour;
        List<string> dayFive;
        List<string> daySix;
        List<string> daySeven;
        WeatherConditions weatherConditions;
        public Day()
        {
            weatherConditions = new WeatherConditions();
            
        }
        public WeatherConditions WeatherConditions
        {
            get => default(LemonadeStand.WeatherConditions);
            set
            {
            }
        }

        public Customer Customer
        {
            get => default(LemonadeStand.Customer);
            set
            {
            }
        }
        public void SetHour()
        {
        
        }
        public void CheckWeatherConditions()
        {
            weatherConditions.GetForecast();
        }
    }
}