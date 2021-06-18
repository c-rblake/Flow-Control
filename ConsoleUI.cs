using System;

namespace Flow_Control
{
    internal class ConsoleUI : IUI
    // TODO SKA GÖRAS OM TILL ETT INTERFACE
    {
        public ConsoleUI()
        {
        }

        public void Print(string message) // Public för interface
        {
            Console.WriteLine(message);
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}