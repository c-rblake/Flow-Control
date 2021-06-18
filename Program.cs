using System;

namespace Flow_Control
{
    class Program
    
    {
        static IUI ui = new ConsoleUI(); // IUI så vi kan byta Interface.
        static Party party = new Party();
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
                    Environment.Exit(0); // Bryter programmets första While Loop
                    break;
                case "1":
                    AddCinemaGoer();
                    break;
                case "2":
                    PrintTicketPrices();
                    break;

                default:
                    ui.Print("Error");
                    break;
            }
        }

        private static void PrintTicketPrices()
        {
            CinemaGoer[] partyMembers = party.GetMembers();
        }

        private static void AddCinemaGoer()
        {
            do
            {

                ui.Print("Please Enter the Age of Cinema goer. Q to Exit");
                string age = Utils.AskForString("Enter Age: ", ui);
                if (age.Equals("Q")) break;

                int age = Utils.AskForInt("Enter Age:", ui);

                CinemaGoer member = new(age);

                party.AddMember(member);

            } while (true);
        }

        private static void ShowMainMenu()
        {
            ui.Print("Type 0 to close the program");
            ui.Print("Type 1 to Enter Cinama goer's Age"); // Better How Many Tickets --> How many are this age... But math..
            ui.Print("Type 2 to Print Ticket Prices");
        }



    }
}
