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

        public Game()
        {
            timeFrame = new TimeFrame();
            player = new Player();
        }
        public void CheckGameResult()
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

   
    }
}