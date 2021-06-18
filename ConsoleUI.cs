using System;

namespace Flow_Control
{
    internal class ConsoleUI
    {
        public ConsoleUI()
        {
        }

        public void Print(string message) // Public för interface
        {
            Console.WriteLine(message);
        }

        internal string GetInput()
        {
            return Console.ReadLine();
        }
    }
}