using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class WeatherConditions
    {

       
        //cloud condition



        Random random;
        public int temperature;
        public string precipitation;
        private bool precipitationActivity;
        private int naturalDisaster;
        bool isCloudy;
        bool isSunny;
        int outcome;
        string currentPrecipitation;
        Day day;
        List<string> typeOfPrecipitation = new List<string>()
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
            HasPrecipitation(6);
            GetTemperature(outcome);
            GeneratePrecipitation();
          
        }

        public void HasPrecipitation(int die)
        {
            if (isCloudy == true)
            {
                if(MainMenu.RollDie(0, die) >= 4)
                {
                    precipitationActivity = true;
                }
            }
            else
            {
                precipitation = "no";
            }
        }
        public void IsCloudy(int die)
        {
            if(MainMenu.RollDie(0, die) < 4)
            {
                    outcome = 0;
               isCloudy = true;
               
            }
            else
            {
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
                return true;
            }

        }
        //public void GetForecast()
        //{
        //    List<string> dayOne = GrabDailyWeather();
        //    List<string> dayTwo = GrabDailyWeather();
        //    List<string> dayThree = GrabDailyWeather();
        //    List<string> dayFour = GrabDailyWeather();
        //    List<string> dayFive = GrabDailyWeather();
        //    List<string> daySix = GrabDailyWeather();
        //    List<string> daySeven = GrabDailyWeather();

        //}
        public List<string> GrabDailyWeather()
        {
            IsCloudy(6);
            IsSunny(6);
            HasPrecipitation(60);
            GetTemperature(outcome);
            GeneratePrecipitation();  
            string textOfTemperature = Convert.ToString(temperature);
            List<string> dayForecastAnalysis = new List<string>()
            {
            textOfTemperature, currentPrecipitation
            };
            return dayForecastAnalysis;
        }
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
            if (temperature < 32 && isCloudy == true && precipitationActivity == true)
            {
                 precipitation = typeOfPrecipitation[MainMenu.RollDie(0, 1)];
                
            }
            if (temperature == 32 && isCloudy == true && precipitationActivity == true)
            {
                 precipitation = typeOfPrecipitation[MainMenu.RollDie(0, 3)];
                
            }
            if (temperature > 32 && isCloudy == true && precipitationActivity == true)
            {
                 precipitation = typeOfPrecipitation[MainMenu.RollDie(2, 3)];
            }
                
        }
 

    }
}