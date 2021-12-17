namespace HotDrinkDispenser.Business.UserInputOutput
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}