using System;

namespace Flow_Control
{
    class Program
    
    {
        static ConsoleUI ui = new ConsoleUI();
        static void Main(string[] args)
        {
            // MAIN MENU
            do
            {
                ShowMainMenu();
                UserInput();

            } while (true);
            
        }

        private static void UserInput()
        {
            switch (ui.GetInput())
            {
                case "0":
                    break; // Bryter programmets första While Loop
                default:
                    ui.Print("Error");
                    break;
            }
        }

        private static void ShowMainMenu()
        {
            ui.Print("Type 0 to close the program");
            ui.Print("Type other things");
        }



    }
}
