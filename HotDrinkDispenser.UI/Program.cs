using DrinkDispenser.Business;
using DrinkDispenser.DataAccessLayer;

var printer = new ConsolePrinter();
var drinkSelector = new DrinkSelector(printer, new ConsoleInputHanler(), new DrinkRepository());
var drinkPriceCalculator = new DrinkPriceCalculator(new DrinkRecipeFactory());

while (true)
{
    var drink = drinkSelector.SelectDrink();
    if (drink != null)
    {
        var price = drinkPriceCalculator.GetDrinkPrice(drink);
        printer.Print("Please insert " + price.ToString("c2"));
    }
}
Console.Read();