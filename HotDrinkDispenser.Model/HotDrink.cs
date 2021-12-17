using HotDrinkDispenser.Model.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinkDispenser.Model.HotDrinks
{
    public class HotDrink
    {
        public HotDrink(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Recipe { get; set; }
    }
}
