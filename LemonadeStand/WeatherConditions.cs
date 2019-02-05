using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class WeatherConditions
    {
        Random random;
        public bool greatWeather;
        public bool goodWeather;
        public bool badWeather;
        public bool terribleWeather;
        public int temperature;
        public string condition;
        public string textOfTemperature;
        public string precipitation;
        private bool precipitationActivity;
        private int naturalDisaster;
        bool isCloudy;
        bool isSunny;
        int outcome;
        string currentPrecipitation;
        public string precipitationAmount;
        Day day;
        public List<string> typeOfPrecipitation = new List<string>()
        {
            "snow", "hail", "rain","rain"
        };
        Game game;
        public WeatherConditions()
        {
            random = new Random();
            outcome = 0;
            IsCloudy(6);
            IsSunny(6);
            HasPrecipitation(15);
            GetTemperature(outcome);
            GeneratePrecipitation();
            GeneratePrecipitationAmount(6);
            

        }

        public void CheckWeatherFavor()
        {
            if (temperature >= 60 && isSunny == true)
            {
                greatWeather = true;
                goodWeather = false;
                badWeather = false;
                terribleWeather = false;
            }
            else if (temperature >= 55 && isCloudy == true && isSunny == false && precipitationActivity == false)
            {
                greatWeather = false;
                goodWeather = true;
                badWeather = false;
                terribleWeather = false;
            }
            else if (temperature < 55 && isCloudy == true && isSunny == false)
            {
                greatWeather = false;
                goodWeather = false;
                badWeather = true;
                terribleWeather = false;
            }
            else if (temperature < 55 && isCloudy == true && isSunny == false && precipitationAmount == "heavy")
            {
                greatWeather = false;
                goodWeather = false;
                badWeather = false;
                terribleWeather = true;
            }
            else
            {
                greatWeather = false;
                goodWeather = true;
                badWeather = false;
                terribleWeather = true;
            }
        }
        public void HasPrecipitation(int die)
        {
            if (isCloudy == true)
            {
                if(MainMenu.RollDie(0, die) > 1)
                {
                    precipitationActivity = true;
                }
            }
            else
            {
                precipitation = "no precipitation";
            }
        }
        public void IsCloudy(int die)
        {
            if(MainMenu.RollDie(0, die) < 4)
            {
               outcome = 0;
               condition = "cloudy";
               isCloudy = true;
               
            }
            else
            {
               condition = "sunny";
               isCloudy = false;
            }
            
        }
        public bool IsSunny(int die)
        {
            //created a parameter and now need to define it without affecting the outcome:  
            if (isCloudy == true)
            {
                return false;
            }
            else
            {
                outcome = 60;
                condition = "clear";
                return true;
            }

        }
        //public List<string> GrabDailyWeather()
        //{
        //    IsCloudy(6);
        //    IsSunny(6);
        //    HasPrecipitation(6);
        //    GetTemperature(outcome);
        //    GeneratePrecipitation();  
        //    string textOfTemperature = Convert.ToString(temperature);
        //    List<string> dayForecastAnalysis = new List<string>()
        //    {
        //    textOfTemperature, currentPrecipitation
        //    };
        //    return dayForecastAnalysis;
        //}
        

        public void GetTemperature(int outcome)
        {
            
            temperature = random.Next(outcome,100);
        }
        public void GeneratePrecipitation()
        {
            if (temperature < 32 && precipitationActivity == true)
            {
                precipitation = typeOfPrecipitation[MainMenu.RollDie(0, 1)];
                
            }
            else if (temperature == 32 && precipitationActivity == true)
            {
                precipitation = typeOfPrecipitation[MainMenu.RollDie(0, 3)];

            }
            else if (temperature > 32 && precipitationActivity == true)
            {
                precipitation = typeOfPrecipitation[MainMenu.RollDie(2, 3)];
            }
            else
            {
                precipitation = "no precipitation";
            }
                
        }
        public void GeneratePrecipitationAmount(int die)
        {
            if(MainMenu.RollDie(0, die) <= die /2 && precipitationActivity == true)
            {
                precipitationAmount = "light";
            }
            else if (MainMenu.RollDie(0, die) >= die /2 && precipitationActivity == true)
            {
                precipitationAmount = "mild";
            }
            else if (MainMenu.RollDie(0, die) == die / 2 && precipitationActivity == true)
            {
                precipitationAmount = "heavy";
            }
            else if (MainMenu.RollDie(0, die) <= die && precipitationActivity == true)
            {
                precipitationAmount = "unknown";
            }
        }
 

    }
}