using DrinkDispenser.Model.Drinks;

namespace DrinkDispenser.DataAccessLayer
{
    public class DrinkRepository : IDrinkRepository
    {
        public List<Drink> GetAvaiableRecipes()
        {
            return new List<Drink> {
                new BlackCoffee(),
                new LongCoffee(),
                new Cappucino(),
                new HotChocolate(),
                new HotTea(),
            };
        }

        public Drink? GetDrinkById(int id)
        {
            return id switch
            {
                0 => new BlackCoffee(),
                1 => new LongCoffee(),
                2 => new Cappucino(),
                3 => new HotChocolate(),
                4 => new HotTea(),
                _ => null,
            };
        }
    }
}
