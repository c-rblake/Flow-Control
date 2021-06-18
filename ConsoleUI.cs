using System;

namespace Flow_Control
{
    internal class ConsoleUI : IUI
    
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
        public void PrintWrite(string message) // Public för interface
        {
            Console.Write(message);
        }
    }
}