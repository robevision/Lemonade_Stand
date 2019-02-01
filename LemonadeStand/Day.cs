using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        WeatherConditions weatherConditions;
        public Day()
        {
            weatherConditions = new WeatherConditions();
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
            WeatherConditions.HasBadWeather(6);
            WeatherConditions.HasGoodWeather(6);
            WeatherConditions.HasPrecipitation(6);
        }
    }
}