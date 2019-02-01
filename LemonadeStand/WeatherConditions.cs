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
        public bool HasBadWeather()
        {
            if(MainMenu.RollDie(0,MainMenu.GetGameMode()) > 4)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool HasGoodWeather()
        {
            if (HasBadWeather() == true)
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