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
        public int sugar;
        public int lemon;
        public int water;
        public int ice;
        public List<int> lemonade;
        public int pitcher = 4;
      //lemon amount, etc use for member variables!!
        //pitcher=7 cups
        //pitcher = 1 sugar, 1 lemon, 1 water, 1 ice
        //SPAWNER
        public Inventory()
        {
            ice = 0;
            lemon = 0;
            sugar = 0;
            water = 0;
        }
        //CAN DO
        public void GrabIngredientsFromStore(int ice, int lemon, int sugar, int water)
        {
            this.ice = ice;
            this.lemon = lemon;
            this.sugar = sugar;
            this.water = water;
        }
        
        public Ingredient Items
        {
            get => default(Ingredient);
            set
            {
            }
        }
    }
}