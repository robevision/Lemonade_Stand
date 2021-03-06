﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    static class MainMenu
    {
        static Random random;
        static MainMenu()
        {
            random = new Random();
        }
        public static void ViewRules()
        {
            Console.WriteLine("What information are you looking for? game objective(1) how to make money(2) recipes(3) weather(4)");
            Console.WriteLine("If you are done reviewing the rules, to exit, type (5)");
            string ruleChoice = Console.ReadLine();
            switch (ruleChoice)
            {
                case "1":
                    Console.WriteLine("You own a lemonade stand and you goal is to turn a profit in the first week. You may continue as many weeks as you would like.");
                    ViewRules();
                    break;
                case "2":
                    Console.WriteLine("Making money is simply how much lemonade you can sell. The better the taste and what price you choose to determine for supply and demand will determine how much money you will have.");
                    ViewRules();
                    break;
                case "3":
                    Console.WriteLine("Recipes are crucial to the lemonade's quality and ultimately its' marketability. There are four ingredients crucial to a recipe. Lemon, ice, water, and sugar. By experimenting with these ingredients you will be able to unlock recipes.");
                    ViewRules();
                    break;
                case "4":
                    Console.WriteLine("Weather will affect how many potential customers will see your lemonade stand. The better the weather, the more likely you will have a greater demand for your lemonade. The weather is given to you before shopping for ingredients. Make sure you assess what would be a proper amount to purchase for the day depending on the weather.");
                    ViewRules();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Please choose a value from 1 to 5");
                    ViewRules();
                    break;
            }
        }
        public static void AskContinue()
        {
            Console.WriteLine("Would you like to continue playing? (Type Yes or No): ");
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
                    Console.WriteLine("Please type either Yes or No.");
                    AskContinue();
                    break;
            }
        }
        public static void ConsoleWelcome()
        {
            Console.WriteLine("Welcome to Lemonade Stand, where you try to build a successful lemonade stand business!");
        }
        public static void AskPlayAgain()
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
        public static int RollDie(int min, int max)
        {
            int result = random.Next(min, max) + 1;
            System.Threading.Thread.Sleep(30);
            return result;
        }
        //public static int GetGameModeDie()
        //{
        //    int gameMode = PassGameMode();
        //    if (gameMode == 1)
        //    {
        //        int die = 6;
        //        return die;
        //    }
        //    if (gameMode == 2)
        //    {
        //        int die = 12;
        //        return die;
        //    }
        //    if (gameMode == 3)
        //    {
        //        int die = 30;
        //        return die;
        //    }
        //    else
        //    {
        //        return 6;
        //    }
            
        //    //WeatherConditions weatherConditions = new WeatherConditions();
        //    //weatherConditions.HasBadWeather(GetGameModeDie());
        //}
        //public static int PassGameMode()
        //{
        //    if (gameMode == null)
        //    {
        //        int gameMode = 1;
        //        return gameMode;
        //    }
        //    else
        //    {
        //        return gameMode;
        //    }
        //}
    }
        
}