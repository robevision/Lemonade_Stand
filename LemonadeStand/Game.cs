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

        public Game()
        {

        }

        public MainMenu mainMenu = new MainMenu();
       

        public Player Player
        {
            get => default(LemonadeStand.Player);
            
        }

        public void RunDay()
        {
            throw new System.NotImplementedException();
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