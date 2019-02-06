using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public abstract class Ingredient
    {
        //HAS A
        public double price;
        public int amount;
        public int predictedAmount;
        public double predictedPrice;
        //SPAWNER
        public Ingredient()
        {
            amount = 0;
            predictedAmount = 0;
            predictedPrice = 0;
               
        }
        //CAN DO
        public abstract void GetAmount();
        public abstract void GetPrice();
    }
}