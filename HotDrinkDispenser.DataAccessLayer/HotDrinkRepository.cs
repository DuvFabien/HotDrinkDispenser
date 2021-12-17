using HotDrinkDispenser.Model.HotDrinks;
using HotDrinkDispenser.Model.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinkDispenser.DataAccessLayer
{
    //This class is supposed to query data from the Database but for the purpose of this kata, this is only returning fake data
    public class HotDrinkRepository : IHotDrinkRepository
    {
        public List<HotDrink>? GetAvaiableRecipes()
        {
            return new List<HotDrink> {
                new HotDrink(0, "Café"),
                new HotDrink(1, "Allongé"),
                new HotDrink(2, "Cappucino"),
                new HotDrink(3, "Chocolat"),
                new HotDrink(4, "Thé")
            };
        }

        public HotDrink? GetRecipeById(int id)
        {
            return id switch
            {
                0 => new HotDrink(0, "Café"),
                1 => new HotDrink(1, "Allongé"),
                2 => new HotDrink(2, "Cappucino"),
                3 => new HotDrink(3, "Chocolat"),
                4 => new HotDrink(4, "Thé"),
                _ => null,
            };
        }
    }
}
