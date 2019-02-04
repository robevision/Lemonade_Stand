using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
    
        public WeatherConditions weatherConditions;
        public Day()
        {
            weatherConditions = new WeatherConditions();
        }
       

        public Customer Customer
        {
            get => default(LemonadeStand.Customer);
            set
            {
            }
        }

        public WeatherConditions WeatherConditions
        {
            get => default(WeatherConditions);
            set
            {
            }
        }


    }
}