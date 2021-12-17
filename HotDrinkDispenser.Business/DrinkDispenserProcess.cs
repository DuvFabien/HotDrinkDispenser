
using DrinkDispenser.Business;
using DrinkDispenser.DataAccessLayer;
using HotDrinkDispenser.Business.UserInputOutput;

namespace HotDrinkDispenser.Business
{
    public class DrinkDispenserProcess : IDrinkDispenserProcess
    {
        public void Process()
        {
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
        }
    }
}
