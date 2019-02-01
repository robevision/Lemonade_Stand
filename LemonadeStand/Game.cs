using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //HAS A
        int gameMode;
        int die;
        TimeFrame timeFrame;
        Player player;
        MarketPlace marketPlace;

        public Game()
        {
            timeFrame = new TimeFrame();
            player = new Player();
            marketPlace = new MarketPlace();
        }
      
        public bool CheckGameResult()
        {
        
            if (timeFrame.DisplayWeek() >= 1 && timeFrame.DisplayDay() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PresentGameResult()
        {
            if (CheckGameResult() == true)
            {
                if (Player.Wallet.DisplayMoney() > Player.Wallet.GetWeeklyBalance())
                {
                    Console.WriteLine("Congratulations on having a successful business! You've earned more than what you started with!");
                    Player.Wallet.CalculateBeginningBalance();
                    MainMenu.AskContinue();
                }
                if (Player.Wallet.DisplayMoney() == Player.Wallet.GetWeeklyBalance())
                {
                    Console.WriteLine("You broke even on your investment as a lemonade stand owner! You did not win, but you also did not lose.");
                    Player.Wallet.CalculateBeginningBalance();
                    MainMenu.AskContinue();
                }
                if (Player.Wallet.DisplayMoney() < Player.Wallet.GetWeeklyBalance())
                {
                    Console.WriteLine("Not good! You did not turn a profit! You have lost the game. You can always appeal by going another week.");
                    Player.Wallet.CalculateBeginningBalance();
                    MainMenu.AskContinue();
                }
            }
            else
            {

            }
        }
        public void ChooseGameMode()
        {
            Console.WriteLine("What level of difficulty would you like to play at? (Enter a value from 1 through 3): ");
            string difficultyLevel = Console.ReadLine();
            switch (difficultyLevel)
            {
                case "1":
                    Console.WriteLine("You chose easy mode.");
                    gameMode = 1;
                    break;
                case "2":
                    Console.WriteLine("You chose normal mode.");
                    gameMode = 2;
                    break;
                case "3":
                    Console.WriteLine("You chose hard mode.");
                    gameMode = 3;
                    break;
                default:
                    Console.WriteLine("Please type a number from 1 through 3.");
                    ChooseGameMode();
                    break;
            }        

        }
        public int GetGameModeDie()
        {
            int gameMode = PassGameMode();
            if(gameMode == 1)
            {
                die = 6;
            }
            if(gameMode == 2)
            {
                die = 12;
            }
            if(gameMode == 3)
            {
                die = 30; 
            }
            return die;
            //WeatherConditions weatherConditions = new WeatherConditions();
            //weatherConditions.HasBadWeather(GetGameModeDie());
        }
        public int PassGameMode()
        {
            if(gameMode== null)
            {
                gameMode = 1;
                return gameMode;
            }
            else
            {
                return gameMode;
            }
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

        public TimeFrame TimeFrame
        {
            get => default(TimeFrame);
            set
            {
            }
        }
    }
}