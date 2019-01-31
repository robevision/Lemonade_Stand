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

        public Recipe recipe = new Recipe();
     

   

        public Wallet Wallet
        {
            get => default(LemonadeStand.Wallet);
            set
            {
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
            throw new System.NotImplementedException();
        }
    }
}