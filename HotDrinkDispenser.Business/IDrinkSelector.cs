using DrinkDispenser.DataAccessLayer;
using DrinkDispenser.Model.Drinks;
using HotDrinkDispenser.Business.UserInputOutput;

namespace DrinkDispenser.Business
{
    public interface IDrinkSelector
    {
        IDrinkRepository DrinkRepository { get; }
        IInputHanler Handler { get; }
        IPrinter Printer { get; }

        Drink? SelectDrink();
    }
}