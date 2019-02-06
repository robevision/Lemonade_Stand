using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    
    public class Inventory
    {
        int cup;
        int cupPrice;
        public double sugar;
        public double lemon;
        public double water;
        public double ice;
        public int pitcher = 4;
        //pitcher=7 cups
        //pitcher = 1 sugar, 1 lemon, 1 water, 1 ice
        //SPAWNER
        //CAN DO
        public Ingredient Items
        {
            get => default(Ingredient);
            set
            {
            }
        }
    }
}