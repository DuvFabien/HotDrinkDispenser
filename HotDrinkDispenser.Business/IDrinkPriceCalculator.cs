using DrinkDispenser.Model.Drinks;

public interface IDrinkPriceCalculator
{
    decimal GetDrinkPrice(Drink drink);
}