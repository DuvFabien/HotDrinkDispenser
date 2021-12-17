using DrinkDispenser.Model.Drinks;

namespace DrinkDispenser.DataAccessLayer
{
    public interface IDrinkRepository
    {
        Drink? GetDrinkById(int id);
        List<Drink> GetAvaiableRecipes();
    }
}