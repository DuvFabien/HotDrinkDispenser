using DrinkDispenser.Model.Drinks;
using DrinkDispenser.Model.Ingredients;

public class DrinkRecipeFactory : IDrinkRecipeFactory
{
    public List<Ingredient> GetRecipeByDrink(Drink drink)
    {
        if (drink is BlackCoffee)
        {
            return new List<Ingredient> { new Coffee(), new Water() };
        }
        if (drink is LongCoffee)
        {
            return new List<Ingredient> { new Coffee(), new Water(), new Water() };
        }
        if (drink is Cappucino)
        {
            return new List<Ingredient> { new Coffee(), new Chocolate(), new Water(), new Cream() };
        }
        if (drink is HotChocolate)
        {
            return new List<Ingredient> { new Chocolate(), new Chocolate(), new Chocolate(), new Milk(), new Milk(), new Water(), new Sugar() };
        }
        if (drink is HotTea)
        {
            return new List<Ingredient> { new Tea(), new Water(), new Water() };
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}