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
                if (Player.Wallet.DisplayMoney() > 10)
                {
                    Console.WriteLine("Congratulations on having a successful business! You've earned more than what you started with!");
                    AskContinue();
                }
                if (Player.Wallet.DisplayMoney() == 10)
                {
                    Console.WriteLine("You broke even on your investment as a lemonade stand owner! You did not win, but you also did not lose.");
                    AskContinue();
                }
            }
            else
            {

            }
        }
        public void AskContinue()
        {
            Console.WriteLine("Would you like to continue playing? (Type yes or no): ");
            string continueGameDecision = Console.ReadLine().ToLower();
            switch (continueGameDecision)
            {
                case "no":
                    AskPlayAgain();
                    break;
                case "n":
                    AskPlayAgain();
                    break;
                case "yes":
                    break;
                case "y":
                    break;
                default:
                    break;
            }
        }
        public void AskPlayAgain()
        {
            Console.WriteLine("You made quite an effort with that lemonade stand business!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Would you like to play again? (Type Yes or No): ");
            string restart = Console.ReadLine().ToLower();
            if (restart == "yes" || restart == "y")
            {
                Game game = new Game();
            }
            else
            {
                Environment.Exit(0);
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

   
    }
}