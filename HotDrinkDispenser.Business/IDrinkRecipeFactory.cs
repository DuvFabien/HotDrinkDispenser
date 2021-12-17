using DrinkDispenser.Model.Drinks;
using DrinkDispenser.Model.Ingredients;

public interface IDrinkRecipeFactory
{
    List<Ingredient> GetRecipeByDrink(Drink drink);
}
