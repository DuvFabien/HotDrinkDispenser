using DrinkDispenser.Model.Drinks;

namespace HotDrinkDispenser.Business
{
    public class DrinkPriceCalculator : IDrinkPriceCalculator
    {
        public DrinkPriceCalculator(DrinkRecipeFactory drinkRecipeFactory)
        {
            DrinkRecipeFactory = drinkRecipeFactory;
        }

        public DrinkRecipeFactory DrinkRecipeFactory { get; }

        public decimal GetDrinkPrice(Drink drink)
        {
            var recipe = DrinkRecipeFactory.GetRecipeByDrink(drink);
            return recipe.Sum(i => i.Price);
        }
    }
}