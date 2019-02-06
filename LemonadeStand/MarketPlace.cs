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
        int iceAmount;
        int lemonAmount;
        int waterAmount;
        int sugarAmount;
        
        public MarketPlace()
        {
         
        }
        //have prices
        public void GenerateIcePrice()
        {
            ice = new Ice();
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
            lemon = new Lemon();
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
            water = new Water();
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
            sugar = new Sugar();
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
        public void BuyIce(Player player)
        {
            Console.WriteLine($"The price of ice is ${ice.price}.");
            PopulateProjectedPrices();
            Console.WriteLine("Would you like to buy ice?");
            string getIceResult = Console.ReadLine().ToLower();
            switch (getIceResult)
            {
                case "yes":
                    Console.WriteLine("How much ice would you like?");
                    string iceTextAmount=Console.ReadLine();
                    try
                    {
                       iceAmount = Convert.ToInt32(iceTextAmount);
                    }
                    catch
                    {
                        Console.WriteLine("Please type a numeric value from 1 or higher.");
                        BuyIce(player);
                    }

                    if (iceAmount >= 1)
                    { 
                        
                        ice.predictedAmount = iceAmount;
                     double projectedAmount = ice.predictedPrice * ice.predictedAmount;
                        if(projectedAmount > player.wallet.money)
                        {
                            Console.WriteLine("You do not have enough to buy! Please move on to another ingredient or try a different amount.");
                            BuyIce(player);
                        }
                        else
                        {
                            ice.amount += iceAmount;
                           double iceBuy= player.wallet.money -= projectedAmount;
                            int iceAdd=ice.amount + iceAmount;
                            double iceTransfer = player.inventory.icePrice;
                            double giveIcePrice = iceTransfer += ice.price;
                            Console.WriteLine($"You purchased {iceAmount} cups of ice at ${ice.price} a cup.");
                            Console.WriteLine($"You now have ${iceBuy} in your wallet.");

                        }
                    }

                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Please type 'yes' or 'no'");
                    BuyIce(player);
                    break;
            }
            
        }
        
        public void BuyLemon(Player player)
        {
            Console.WriteLine($"The price of a lemon is ${lemon.price}.");
            PopulateProjectedPrices();
            Console.WriteLine("Would you like to buy lemon?");
            string getLemonResult = Console.ReadLine().ToLower();
            switch (getLemonResult)
            {
                case "yes":
                    Console.WriteLine("How many lemons would you like?");
                    string lemonTextAmount = Console.ReadLine();
                    try
                    {
                        lemonAmount = Convert.ToInt32(lemonTextAmount);
                    }
                    catch
                    {
                        Console.WriteLine("Please type a numeric value from 1 or higher.");
                        BuyLemon(player);
                    }

                    if (lemonAmount >= 1)
                    {

                        lemon.predictedAmount = lemonAmount;
                        double projectedAmount = lemon.predictedPrice * lemon.predictedAmount;
                        if (projectedAmount > player.wallet.money)
                        {
                            Console.WriteLine("You do not have enough to buy! Please move on to another ingredient or try a different amount.");
                            BuyLemon(player);
                        }
                        else
                        {
                            lemon.amount += lemonAmount;
                            double lemonBuy = player.wallet.money -= projectedAmount;
                            double lemonTransfer = player.inventory.lemonPrice;
                            double giveLemonPrice = lemonTransfer += lemon.price;
                            int lemonAdd = lemon.amount + lemonAmount;
                            Console.WriteLine($"You purchased {lemonAmount} lemon(s) at ${lemon.price} a lemon.");
                            Console.WriteLine($"You now have ${lemonBuy} in your wallet.");

                        }
                    }

                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Please type 'yes' or 'no'");
                    BuyLemon(player);
                    break;
            }
        }
        public void BuySugar(Player player)
        {
            Console.WriteLine($"The price of sugar is ${sugar.price}.");
            PopulateProjectedPrices();
            Console.WriteLine("Would you like to buy sugar?");
            string getSugarResult = Console.ReadLine().ToLower();
            switch (getSugarResult)
            {
                case "yes":
                    Console.WriteLine("How much sugar would you like?");
                    string sugarTextAmount = Console.ReadLine();
                    try
                    {
                        sugarAmount = Convert.ToInt32(sugarTextAmount);
                    }
                    catch
                    {
                        Console.WriteLine("Please type a numeric value from 1 or higher.");
                        BuySugar(player);
                    }

                    if (sugarAmount >= 1)
                    {

                        sugar.predictedAmount = sugarAmount;
                        double projectedAmount = sugar.predictedPrice * sugar.predictedAmount;
                        if (projectedAmount > player.wallet.money)
                        {
                            Console.WriteLine("You do not have enough to buy! Please move on to another ingredient or try a different amount.");
                            BuySugar(player);
                        }
                        else
                        {
                            sugar.amount += sugarAmount;
                            double sugarBuy = player.wallet.money -= projectedAmount;
                            double sugarTransfer = player.inventory.sugarPrice;
                            double giveSugarPrice = sugarTransfer += sugar.price;
                            int sugarAdd = sugar.amount + sugarAmount;
                            Console.WriteLine($"You purchased {sugarAmount} cup(s) of sugar at ${sugar.price} a cup.");
                            Console.WriteLine($"You now have ${sugarBuy} in your wallet.");

                        }
                    }

                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Please type 'yes' or 'no'");
                    BuySugar(player);
                    break;
            }
        }
        public void BuyWater(Player player)
        {
            Console.WriteLine($"Water is ${water.price}.");
            PopulateProjectedPrices();
            Console.WriteLine("Would you like to get water?");
            string getWaterResult = Console.ReadLine().ToLower();
            switch (getWaterResult)
            {
                case "yes":
                    Console.WriteLine("How much water would you like?");
                    string waterTextAmount = Console.ReadLine();
                    try
                    {
                        waterAmount = Convert.ToInt32(waterTextAmount);
                    }
                    catch
                    {
                        Console.WriteLine("Please type a numeric value from 1 or higher.");
                        BuyWater(player);
                    }

                    if (waterAmount >= 1)
                    {

                        water.predictedAmount = waterAmount;
                        double projectedAmount = water.predictedPrice * water.predictedAmount;
                        if (projectedAmount > player.wallet.money)
                        {
                            Console.WriteLine("You do not have enough to buy! Please move on to another ingredient or try a different amount.");
                            BuyWater(player);
                        }
                        else
                        {

                            water.amount += waterAmount;
                            double waterBuy = player.wallet.money -= projectedAmount;
                            int waterAdd = water.amount + waterAmount;
                            double waterTransfer = player.inventory.waterPrice;
                            double giveWaterPrice = waterTransfer += water.price;
                            Console.WriteLine($"You purchased {waterAmount} cup(s) of water at ${water.price} a cup.");
                            Console.WriteLine($"You now have ${waterBuy} in your wallet.");
                        }
                    }

                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Please type 'yes' or 'no'");
                    BuyWater(player);
                    break;
            }
            try
            {
                player.Inventory.GrabIngredientsFromStore(ice.amount, lemon.amount, sugar.amount, water.amount);
            }
            catch
            {

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
        public void DecideToShop(Player player)
        {
            Console.WriteLine("Would you like to purchase ingredients for your lemonade?");
            string shopDecision = Console.ReadLine().ToLower();
            switch (shopDecision)
            {
                case "yes":
                PurchaseIngredients(player);
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Please type 'yes' or 'no'");
                    DecideToShop(player);
                    break;
            }
           
        }
        public void PurchaseIngredients(Player player)
        {
            EvaluateMarketPrices();
            BuyIce(player);
            BuyLemon(player);
            BuySugar(player);
            BuyWater(player);
        }
        //public void GiveCurrentIngredientAmounts()
        //{
        //    GiveCurrentIceAmount();
        //    GiveCurrentLemonAmount();
        //    GiveCurrentSugarAmount();
        //    GiveCurrentWaterAmount();
        //}
        //public int GiveCurrentLemonAmount()
        //{
        //    int lemonTally = lemon.amount;

        //    return lemonTally;

        //}
        //public int GiveCurrentIceAmount()
        //{
        //    int iceTally = ice.amount;
        //    return iceTally;

        //}
        //public int GiveCurrentWaterAmount()
        //{
        //    int waterTally = water.amount;
        //    return waterTally;

        //}
        //public int GiveCurrentSugarAmount()
        //{
        //    int sugarTally = sugar.amount;
        //    return sugarTally;
        //}
    }
}