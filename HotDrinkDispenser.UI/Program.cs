using HotDrinkDispenser.Business;
using HotDrinkDispenser.DataAccessLayer;


while (true)
{
    var drinkSelector = new HotDrinkSelector(new ConsolePrinter(), new ConsoleInputHanler(), new HotDrinkRepository());
    var drinkid = drinkSelector.SelectDrink();
}
Console.Read();