namespace HotDrinkDispenser.Business.UserInputOutput
{
    public class ConsoleInputHanler : IInputHanler
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}