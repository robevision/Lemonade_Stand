using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class WeatherConditions
    {
        Random random;
        int temperature;
        private bool precipitation;
        private int naturalDisaster;
        bool badWeather;
        bool goodWeather;
        int outcome;
        string currentPrecipitation;
        List<string> typeOfPrecipitation = new List<string>()
        {
            "snow", "hail", "rain","rain",
        };
        Game game;
        public WeatherConditions()
        {
            HasBadWeather(6);
            HasGoodWeather(6);
            HasPrecipitation(6);
            GetTemperature(outcome);
            GeneratePrecipitation();
          
        }

        public void HasPrecipitation(int die)
        {
            if (badWeather == true)
            {
                if(MainMenu.RollDie(0, die) >= 4)
                {
                    precipitation = true;
                }
            }
            else
            {
                currentPrecipitation = "none";
            }
        }
        public void HasBadWeather(int die)
        {
            if(MainMenu.RollDie(0, die) < 4)
            {
                    outcome = 0;
               bool badWeather = true;
               
            }
            else
            {
               bool badWeather = false;
            }
            
        }
        public bool HasGoodWeather(int die)
        {
            //created a parameter and now need to define it without affecting the outcome:  
            if (badWeather == true)
            {
                return false;
            }
            else
            {
                outcome = 60;
                return true;
            }

        }
        public void GetForecast()
        {
            GrabDailyWeather();
            
            //dayTwo=
            HasBadWeather(6);
            HasGoodWeather(6);
            HasPrecipitation(6);
            GetTemperature(outcome);
            GeneratePrecipitation();
            //dayThree=
            HasBadWeather(6);
            HasGoodWeather(6);
            HasPrecipitation(6);
            GetTemperature(outcome);
            GeneratePrecipitation();
            //dayFour=
            HasBadWeather(6);
            HasGoodWeather(6);
            HasPrecipitation(6);
            GetTemperature(outcome);
            GeneratePrecipitation();
            //dayFive=
            HasBadWeather(6);
            HasGoodWeather(6);
            HasPrecipitation(6);
            GetTemperature(outcome);
            GeneratePrecipitation();
            //daySix=
        }
        public void GrabDailyWeather()
        {
            HasBadWeather(6);
            HasGoodWeather(6);
            HasPrecipitation(6);
            GetTemperature(outcome);
            GeneratePrecipitation();
            Console.WriteLine(temperature);
            Console.WriteLine(currentPrecipitation);
            string textOfTemperature = Convert.ToString(temperature);
            List<string> dayForecastAnalysis = new List<string>()
            {
            textOfTemperature, currentPrecipitation
            };
        }
        public void GetActualWeather()
        {

        }
        public void GetTemperature(int outcome)
        {
            random = new Random();
            temperature = random.Next(outcome,100);
        }
        public void GeneratePrecipitation()
        {
            if (temperature < 32 && badWeather == true && precipitation == true)
            {
                string currentPrecipitation = typeOfPrecipitation[MainMenu.RollDie(0, 1)];
                
            }
            if (temperature == 32 && badWeather == true && precipitation == true)
            {
                string currentPrecipitation = typeOfPrecipitation[MainMenu.RollDie(0, 3)];
                
            }
            if (temperature > 32 && badWeather == true && precipitation == true)
            {
                string currentPrecipitation = typeOfPrecipitation[MainMenu.RollDie(2, 3)];
            }
                
        }

    }
}