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
        public void CheckGameResult()
        {
        
         if (timeFrame.DisplayWeek() >= 1 && timeFrame.DisplayDay() == 0)
            {
                //if (Player.Wallet.DisplayMoney() == +int);
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