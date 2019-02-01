using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class WeatherConditions
    {
        private int temperature;
        private bool precipitation;
        private int naturalDisaster;
        bool badWeather;
        bool goodWeather;
        Game game;

        public Precipitation Precipitation
        {
            get => default(Precipitation);
            set
            {
            }
        }

        public void HasPrecipitation()
        {
            throw new System.NotImplementedException();
        }
        public void HasBadWeather(int die)
        {
            if(MainMenu.RollDie(0, die) < 4)
            {
               bool badWeather = true;
               
            }
            else
            {
               bool badWeather = false;
            }
            
        }
        public bool HasGoodWeather()
        {
            //created a parameter and now need to define it without affecting the outcome:  
            if (badWeather == true)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}