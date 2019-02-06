using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //HAS A
        //int gameMode;
        //TimeFrame timeFrame;
        Player player;
        public MarketPlace marketPlace;
        string playLength;
        int playLengthNumber;
        int amountOfDays;
        Day day; 
        List<Day> daysOfWeek;

        public Game()
        {
            daysOfWeek = new List<Day>();
            player = new Player();
            marketPlace = new MarketPlace();
        }
        //merge two methods for simplification
      public void GetPlayLength()
        {
            Console.WriteLine("How many days would you like to play for? Please input a week or more.");
            playLength = Console.ReadLine();
            try
            {
                playLengthNumber = Convert.ToInt32(playLength);
            }
            catch
            {
                Console.WriteLine("Please enter a NUMBER of days greater or equal to a week.");
                GetPlayLength();
            }
            if(playLengthNumber < 7)
            {
                Console.WriteLine("Please enter a value greater or equal to a week.");
                GetPlayLength();
            }
        }
        public void ConvertToDays()
        {
            for (int i = 0; i < playLengthNumber; i++)
            {
                day = new Day();
                daysOfWeek.Add(day);
            }
        }
        public void DisplayWeeklyWeather()
        {
            try
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine($"The sky is {daysOfWeek[i].weatherConditions.condition}, it is {daysOfWeek[i].weatherConditions.temperature}°F, with {daysOfWeek[i].weatherConditions.precipitationAmount} {daysOfWeek[i].weatherConditions.precipitation}.");
                    System.Threading.Thread.Sleep(2000);
                }
            }
            catch
            {
                return;
            }
        }

    
        public void RunGame()
        {
            GetPlayLength();
            ConvertToDays();
            DisplayWeeklyWeather();
            player.CheckWallet();
            for (int i = 0; i < 7; i++)
            {
                daysOfWeek[i].weatherConditions.GetActualWeather();
            }
            
            //daysOfWeek[0].weatherConditions.actualWeather;

            //this is going through each day with the forecast from each day. Not right in its current iteration.
            for (int i = 0; i < 7; i++)
            {
                
                daysOfWeek[i].RunDay(marketPlace, player);
            }
            playLengthNumber -= 7;
            if(playLengthNumber< 7)
            {
                CheckEndGame();
            }
            else
            {
                RunGame();
            }
           // customer.Buy(daysOfWeek[0].weatherConditions);
        }

        public void CheckEndGame()
        {
            if (player.wallet.money > 10)
            {
                Console.WriteLine("Congratulations! You turned a profit with your lemonade stand!");
                Environment.Exit(0);
            }
            else if (player.wallet.money == 10)
            {
                Console.WriteLine("You didn't turn a profit, but you didn't lose any money. You came out of this endeavor as, meh.");
                Environment.Exit(0);
            }
            else if (player.wallet.money < 10)
            {
                Console.WriteLine("You lost money on your lemonade stand business. You effectively failed.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Your business did not have a permit and any profits you made were confiscated by the government and you are off to do some hard time. Tough luck.");
                Environment.Exit(0);
            }
        }
        public void DisplayDailyWeather()
        {
            Console.WriteLine($"The sky is {daysOfWeek[0].weatherConditions.condition}, it is {daysOfWeek[0].weatherConditions.temperature}°F, with {daysOfWeek[0].weatherConditions.precipitationAmount}{daysOfWeek[0].weatherConditions.precipitation}.");
        }

        //public void DisplayActualWeather()
        //{
        //    Console.WriteLine(daysOfWeek[0].weatherConditions.actualWeather);
           
        //}
        public void OpenStand()
        {
            
        }
        
        
        public Player Player
        {
            get => default(LemonadeStand.Player);
            
        }

        

        public MarketPlace MarketPlace
        {
            get => default(LemonadeStand.MarketPlace);
            set
            {
            }
        }

        public Day Day
        {
            get => default(Day);
            set
            {
            }
        }
    }
}