using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    
    public class Inventory
    {
        int cup;
        public int sugar;
        public double sugarPrice;
        public int lemon;
        public double lemonPrice;
        public int water;
        public double waterPrice;
        public int ice;
        public double icePrice;
        public List<int> lemonade;
        public int pitcher;
        public double recipePrice;
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
            pitcher = 4;
            recipePrice = 10.50;
        }
        //CAN DO
        public void GrabIngredientsFromStore(int ice, int lemon, int sugar, int water)
        {
            this.ice = ice;
            this.lemon = lemon;
            this.sugar = sugar;
            this.water = water;
        }
        public void checkForLemonade(MarketPlace marketPlace, Player player)
        {
            if (pitcher == 0)
            {
                Console.WriteLine("You do not have any lemonade made. Would you still like to continue through the day?");
                string continueThruDayPrompt = Console.ReadLine().ToLower();
                switch (continueThruDayPrompt)
                {
                    case "yes":
                        break;
                    case "no":
                        marketPlace.DecideToShop(player);
                        break;
                    default:
                        Console.WriteLine("Enter either 'yes' or 'no'.");
                        checkForLemonade(marketPlace, player);
                        break;
                }
            }
            else
            {
                
            }
                    
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