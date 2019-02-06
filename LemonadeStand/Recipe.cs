using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Recipe
    {
        public double recipePrice = 10.50;
        public Recipe(Player player)
        {
            MakePitcher(player);
        }
        public void MakePitcher(Player player)
        {
            CreateGenericRecipe(player);
        }
        public void SetRecipePrice(Player player)
        {
            recipePrice = player.inventory.sugarPrice + player.inventory.icePrice + player.inventory.lemonPrice + player.inventory.waterPrice;
        }
        public void CreateGenericRecipe(Player player)
        {
            player.Inventory.pitcher++;
        }
        //public void CreateSpecialtyRecipe()
        //{

        //}
    }
}