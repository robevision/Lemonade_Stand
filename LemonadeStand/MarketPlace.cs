using System;
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