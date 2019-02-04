using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class WeatherConditions
    {
        Random random;
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
        public void DisplayDailyWeather()
        {
            Console.WriteLine($"The temperature for {day} is {temperature} and there is {currentPrecipitation} precipitation.");
        }

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
 

    }
}