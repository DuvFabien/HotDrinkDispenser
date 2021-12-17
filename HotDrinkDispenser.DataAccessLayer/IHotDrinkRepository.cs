using HotDrinkDispenser.Model.HotDrinks;

namespace HotDrinkDispenser.DataAccessLayer
{
    public interface IHotDrinkRepository
    {
        HotDrink? GetRecipeById(int id);
        List<HotDrink>? GetAvaiableRecipes();
    }
}