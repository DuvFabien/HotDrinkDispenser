using DrinkDispenser.DataAccessLayer;
using DrinkDispenser.Model.Drinks;
using HotDrinkDispenser.Business.UserInputOutput;

namespace DrinkDispenser.Business
{
    public class DrinkSelector : IDrinkSelector
    {
        public DrinkSelector(IPrinter printer, IInputHanler handler, IDrinkRepository drinkRepository)
        {
            Printer = printer;
            Handler = handler;
            DrinkRepository = drinkRepository;

            _drinks = DrinkRepository.GetAvaiableRecipes();
        }

        public IPrinter Printer { get; }
        public IInputHanler Handler { get; }
        public IDrinkRepository DrinkRepository { get; }

        private readonly List<Drink> _drinks;

        public Drink? SelectDrink()
        {
            DisplayAvailableDrinks();
            Printer.Print("Please select drink's id then press enter");
            string input = Handler.GetInput();

            if (!int.TryParse(input, out int id))
            {
                Printer.Print("Invalid selection");
                return null;
            }

            return _drinks.FirstOrDefault(d => d.Id == id);
        }

        private void DisplayAvailableDrinks()
        {
            if (_drinks == null || !_drinks.Any())
            {
                Printer.Print("Available products:");
                Printer.Print("No products avaiable");
                return;
            }

            Printer.Print("");
            Printer.Print("Available products:");
            foreach (var drink in _drinks)
            {
                Printer.Print("#" + drink.Id + ": " + drink.Name);
            }
        }
    }
}
