using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        List<string> weather;
        public WeatherConditions weatherConditions;
        Game game;
        public Day()
        {
            weatherConditions = new WeatherConditions();
            //weather = weatherConditions.GrabDailyWeather();
            game.AddDays();
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