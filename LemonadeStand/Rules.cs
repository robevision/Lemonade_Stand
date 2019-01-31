using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    static class Rules
    {

        static void ViewRules()
        {
            Console.WriteLine("What information are you looking for? game objective(1) how to make money(2) recipes(3) weather(4)");
            string ruleChoice = Console.ReadLine();
            switch (ruleChoice)
            {
                case "1":
                    Console.WriteLine("You own a lemonade stand and you goal is to turn a profit in the first week. You may continue as many weeks as you would like.");
                    break;
                case "2":
                    Console.WriteLine("Making money is simply how much lemonade you can sell. The better the taste and what price you choose to determine for supply and demand will determine how much money you will have.");
                    break;
                default:
                    Console.WriteLine("Please choose a value from 1 to 4");
                    break;
            }
        }
    }
}