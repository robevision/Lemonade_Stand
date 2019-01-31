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
        private int day;
        private int amountOfDays;

        public Game()
        {
            amountOfDays = 0;
        }


        public Player Player
        {
            get => default(LemonadeStand.Player);
            
        }

        public void RunTime()
        {
            amountOfDays++;
            if (amountOfDays == 7)
            {

            }
            
            Day day = new Day();
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
            get => default(LemonadeStand.TimeFrame);
            set
            {
            }
        }
    }
}