using HotDrinkDispenser.DataAccessLayer;
using HotDrinkDispenser.Model.HotDrinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinkDispenser.Business
{
    public class HotDrinkDispenserManager
    {
        private List<HotDrink>? _drinks;

        public HotDrinkDispenserManager(IPrinter printer, IHotDrinkRepository hotDrinkRepository)
        {
            Printer = printer;
            HotDrinkRepository = hotDrinkRepository;

            Initialize();
        }

        public IPrinter Printer { get; }
        public IHotDrinkRepository HotDrinkRepository { get; }

        public void PrintAvailableDrinks()
        {
            Printer.Print("Welcome");

            if (_drinks == null || !_drinks.Any())
            {

                Printer.Print("Available products:");
                Printer.Print("No products avaiable");
                return;
            }

            Printer.Print("");
            Printer.Print("Available products: (press key number to get drink)");
            for (int i = 0; i < _drinks.Count - 1; i++)
            {
                var drink = _drinks[i];
                Printer.Print("#" + i + ": " + drink.Name);
            }
        }

        private void Initialize()
        {
            _drinks = HotDrinkRepository.GetAvaiableRecipes();
        }
    }
}
