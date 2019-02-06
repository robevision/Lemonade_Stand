using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        private int score;
        private int money;
        public string playerName;
        public double cupPrice;
        public Wallet wallet;
        public Inventory inventory;
        public int pitcherAmount;
        public Player()
        {
            wallet = new Wallet();
            inventory = new Inventory();

        }
        public void ReviewRecipePrice()
        {
            double marketPrice = inventory.recipePrice;
            try
            { 
                marketPrice = inventory.sugarPrice + inventory.icePrice + inventory.lemonPrice + inventory.waterPrice;
            }
            catch
            {
              marketPrice= 10.50;
            }
            if(marketPrice == null)
            {
                marketPrice = 10.50;
            }
        }
            public void PickAmountOfRecipes()
        {
            Console.WriteLine("You have a generic mix recipe to create. This is 1 part ice, 1 part lemon, 1 part water, and 1 part sugar.");
            Console.WriteLine("How many pitchers would you like to make?");
            try
            {
                int pitcherAmount=Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please type a number. Yes, a number. (example: 1 ).");
                PickAmountOfRecipes();
            }
            if(pitcherAmount>0)
            inventory.lemonade.Add(inventory.sugar);
            inventory.lemonade.Add(inventory.lemon);
            inventory.lemonade.Add(inventory.water);
            inventory.lemonade.Add(inventory.ice);
        }
        public void AskForCupPrice()
        {
            Console.WriteLine("What price would you like to sell a cup of lemonade for?");
            try
            {
                cupPrice = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please type a number. Yes, a number. (example: 1 ).");
                AskForCupPrice();
            }
        }


        public Inventory Inventory
        {
            get => default(LemonadeStand.Inventory);
            set
            {
            }
        }

        public void GetPayment()
        {
            throw new System.NotImplementedException();
        }

        public void GetResources()
        {
            throw new System.NotImplementedException();
        }

        public void CheckWeather()
        {
            throw new System.NotImplementedException();
        }

        public void CheckWallet()
        {
            Console.WriteLine($"You have ${wallet.DisplayMoney()} in your wallet.");
        }

        public Wallet Wallet
        {
            get => default(Wallet);
            set
            {
            }
        }

        public Player Player1
        {
            get => default(Player);
            set
            {
            }
        }

        public Recipe Recipe
        {
            get => default(Recipe);
            set
            {
            }
        }
    }
}