using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        public Day()
        {
            CheckWeatherConditions();
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

        }
    }
}