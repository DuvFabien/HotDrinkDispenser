﻿namespace HotDrinkDispenser.Business
{
    public class ConsoleInputHanler : IInputHanler
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}