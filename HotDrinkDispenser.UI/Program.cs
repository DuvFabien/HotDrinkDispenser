using HotDrinkDispenser.Business;
using HotDrinkDispenser.DataAccessLayer;

var dispenser = new HotDrinkDispenserManager(new ConsolePrinter(), new HotDrinkRepository());
dispenser.PrintAvailableDrinks();

Console.Read();