namespace DrinkDispenser.Model.Drinks
{
    public abstract class Drink
    {
        public Drink(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
