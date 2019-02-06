using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {

        static void Main(string[] args)
        {
            Game game = new Game();
            MainMenu.ConsoleWelcome();
            MainMenu.ViewRules();
            game.RunGame();
            System.Threading.Thread.Sleep(1000);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
