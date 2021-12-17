using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinkDispenser.Model.Ingredients
{
    public abstract class Ingredient
    {
        protected Ingredient(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; }
        public decimal Price { get; }
    }
}
