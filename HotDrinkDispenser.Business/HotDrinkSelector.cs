using HotDrinkDispenser.DataAccessLayer;
using HotDrinkDispenser.Model.HotDrinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinkDispenser.Business
{
    public class HotDrinkSelector
    {
        public HotDrinkSelector(IPrinter printer, IInputHanler handler, IHotDrinkRepository hotDrinkRepository)
        {
            Printer = printer;
            Handler = handler;
            HotDrinkRepository = hotDrinkRepository;
        }

        public IPrinter Printer { get; }
        public IInputHanler Handler { get; }
        public IHotDrinkRepository HotDrinkRepository { get; }

        public int SelectDrink()
        {
            DisplayAvailableDrinks();
            return GetSelectedDrink();
        }

        private int GetSelectedDrink()
        {
            string input = string.Empty;
            int id;
            while (!int.TryParse(input, out id))
            {
                Printer.Print("Please select drink's id then press enter");
                input = Handler.GetInput();
            }
            return id;
        }

        private void DisplayAvailableDrinks()
        {
            Printer.Print("Welcome");

            var drinks = HotDrinkRepository.GetAvaiableRecipes();
            if (drinks == null || !drinks.Any())
            {

                Printer.Print("Available products:");
                Printer.Print("No products avaiable");
                return;
            }

            Printer.Print("");
            Printer.Print("Available products:");
            foreach (var drink in drinks)
            {
                Printer.Print("#" + drink.Id + ": " + drink.Name);
            }
        }
    }
}
