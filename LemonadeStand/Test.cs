using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Test
    {
        Random random;
        int result;

        public Test()
        {
            RollDie(0,6);
            DisplayDieRoll();

        }
        public int RollDie(int min, int max)
        {
            random = new Random();
            result = random.Next(min, max);
            return result;
        }
        public void DisplayDieRoll()
        {
            Console.WriteLine(result);
            System.Threading.Thread.Sleep(1000);

        }
    }
}