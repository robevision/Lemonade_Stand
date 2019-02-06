﻿using System;
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
        public double cupPrice = 2.50;
        public Wallet wallet;
        public Inventory inventory;
        public Player()
        {
            wallet = new Wallet();
            CheckWallet();
            inventory = new Inventory();

        }
        public void PickAmountOfRecipes()
        {
            Console.WriteLine();
            inventory.lemonade.Add(inventory.sugar);
            inventory.lemonade.Add(inventory.lemon);
            inventory.lemonade.Add(inventory.water);
            inventory.lemonade.Add(inventory.ice);
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