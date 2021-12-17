namespace DrinkDispenser.Model.Ingredients
{
    public abstract class Ingredient
    {
        protected Ingredient(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; }
        public decimal Price { get; }
    }
}
