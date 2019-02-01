using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //HAS A
        public int round;
        private int winner;
        TimeFrame timeFrame;
        Player player;
        MarketPlace marketPlace;
        Random random;
        int[] rolls;
        int result;

        public Game()
        {
            timeFrame = new TimeFrame();
            player = new Player();
            marketPlace = new MarketPlace();
        }
        public int RollDie()
        {
            random = new Random();
            result = rolls[random.Next(0 , 6)];
            return result;
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