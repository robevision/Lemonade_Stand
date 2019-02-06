﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class MarketPlace
    {
        Lemon lemon;
        Water water;
        Sugar sugar;
        Ice ice;
        Wallet wallet;
        
        public MarketPlace()
        {
         
        }
        //have prices
        public void GenerateIcePrice()
        {
           int result = MainMenu.RollDie(0, 10);
            if (result >= 5)
            {
                ice.price = 0.10;
            }
            else
            {
                ice.price = 0.05;
            }
        }
        public void GenerateLemonPrice()
        {
            int result = MainMenu.RollDie(0, 10);
            if (result >= 5)
            {
                lemon.price = 0.25;
            }
            else
            {
                lemon.price = 0.10;
            }
        }
        public void GenerateWaterPrice()
        {
            int result = MainMenu.RollDie(0, 10);
            if (result >= 5)
            {
                water.price = 0.05;
            }
            else
            {
                water.price = 0.00;
            }
        }
        public void GenerateSugarPrice()
        {
            int result = MainMenu.RollDie(0, 10);
            if (result >= 5)
            {
                sugar.price = 0.75;
            }
            else
            {
                sugar.price = 0.50;
            }
        }
        public void PopulateProjectedPrices()
        {
            ice.predictedPrice = ice.price;
            lemon.predictedPrice = lemon.price;
            water.predictedPrice = water.price;
            sugar.predictedPrice = sugar.price;
        }
        public void BuyIce()
        {
            Console.WriteLine($"The price of ice is ${ice.price}.");
            PopulateProjectedPrices();
            Console.WriteLine("Would you like to buy ice?");
            string getIceResult = Console.ReadLine().ToLower();
            switch (getIceResult)
            {
                case "yes":
                    Console.WriteLine("How much ice would you like?");
                    string iceTextAmount=Console.ReadLine().ToLower();
                    int iceAmount=Convert.ToInt32(iceTextAmount);
                    
                    if (iceAmount >= 1)
                    { 
                        wallet = new Wallet();
                        ice.predictedAmount = Convert.ToInt32(iceAmount);
                     double projectedAmount = ice.predictedPrice * ice.predictedAmount;
                        if(projectedAmount > wallet.money)
                        {
                            Console.WriteLine("You do not have enough to buy! Please move on to another ingredient or try a different amount.");
                            BuyIce();
                        }
                        else
                        {
                            Console.WriteLine("Please type a numeric value from 1 or higher.");
                            BuyIce();
                        }
                    }

                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Please type 'yes' or 'no'");
                    BuyIce();
                    break;
            }
            if (wallet.money >= ice.price)
            {
                ice.amount++;
            }
            
        }
        public void BuyLemon()
        {
            Console.WriteLine($"The price of a lemon is ${lemon.price}.");
            PopulateProjectedPrices();
            Console.WriteLine("Would you like to buy a lemon?");
            string getLemonResult = Console.ReadLine().ToLower();
            switch (getLemonResult)
            {
                case "yes":
                    Console.WriteLine("How many lemons would you like?");
                    string lemonTextAmount = Console.ReadLine().ToLower();
                    int lemonAmount = Convert.ToInt32(lemonTextAmount);

                    if (lemonAmount >= 1)
                    {
                        wallet = new Wallet();
                        lemon.predictedAmount = Convert.ToInt32(lemonAmount);
                        double projectedAmount = lemon.predictedPrice * lemon.predictedAmount;
                        if (projectedAmount > wallet.money)
                        {
                            Console.WriteLine("You do not have enough to buy! Please move on to another ingredient or try a different amount.");
                            BuyLemon();
                        }
                        else
                        {
                            Console.WriteLine("Please type a numeric value from 1 or higher.");
                            BuyLemon();
                        }
                    }

                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Please type 'yes' or 'no'");
                    BuyLemon();
                    break;
            }
            if (wallet.money >= lemon.price)
            {
                lemon.amount++;
            }

        }
        public void BuySugar()
        {
            Console.WriteLine($"The price of sugar is ${sugar.price}.");
            PopulateProjectedPrices();
            Console.WriteLine("Would you like to buy sugar?");
            string getSugarResult = Console.ReadLine().ToLower();
            switch (getSugarResult)
            {
                case "yes":
                    Console.WriteLine("How much sugar would you like?");
                    string sugarTextAmount = Console.ReadLine().ToLower();
                    int sugarAmount = Convert.ToInt32(sugarTextAmount);

                    if (sugarAmount >= 1)
                    {
                        wallet = new Wallet();
                        sugar.predictedAmount = Convert.ToInt32(sugarAmount);
                        double projectedAmount = sugar.predictedPrice * sugar.predictedAmount;
                        if (projectedAmount > wallet.money)
                        {
                            Console.WriteLine("You do not have enough to buy! Please move on to another ingredient or try a different amount.");
                            BuySugar();
                        }
                        else
                        {
                            Console.WriteLine("Please type a numeric value from 1 or higher.");
                            BuySugar();
                        }
                    }

                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Please type 'yes' or 'no'");
                    BuySugar();
                    break;
            }
            if (wallet.money >= sugar.price)
            {
                sugar.amount++;
            }

        }
        public void BuyWater()
        {
            Console.WriteLine($"Water is ${water.price}.");
            PopulateProjectedPrices();
            Console.WriteLine("Would you like to get water?");
            string getWaterResult = Console.ReadLine().ToLower();
            switch (getWaterResult)
            {
                case "yes":
                    Console.WriteLine("How much water would you like?");
                    string waterTextAmount = Console.ReadLine().ToLower();
                    int waterAmount = Convert.ToInt32(waterTextAmount);

                    if (waterAmount >= 1)
                    {
                        wallet = new Wallet();
                       water.predictedAmount = Convert.ToInt32(waterAmount);
                        double projectedAmount = water.predictedPrice * water.predictedAmount;
                        if (projectedAmount > wallet.money)
                        {
                            Console.WriteLine("You do not have enough to buy! Please move on to another ingredient or try a different amount.");
                            BuyWater();
                        }
                        else
                        {
                            Console.WriteLine("Please type a numeric value from 1 or higher.");
                            BuyWater();
                        }
                    }

                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Please type 'yes' or 'no'");
                    BuyWater();
                    break;
            }
            if (wallet.money >= water.price)
            {
                water.amount++;
            }

        }
        public void EvaluateMarketPrices()
        {
            GenerateSugarPrice();
            GenerateIcePrice();
            GenerateLemonPrice();
            GenerateWaterPrice();
            Console.WriteLine($"A cup of sugar costs${sugar.price}, half a bag of ice costs ${ice.price}, a lemon costs ${lemon.price}, and water is {water.price}.");
        }
        public void PurchaseIngredients()
        {

        }
    }
}