﻿using System;

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
                    RepeatTenTimes();
                    break;
                case "3":
                    PrintTicketPrices();
                    break;
                case "4":
                    ImplementSplit();
                    break;

                default:
                    ui.Print("Error");
                    break;
            }
        }

        private static void ImplementSplit()
        {
            ui.Print("Please enter a sentence with at least 3 words:");
            var cmdArgs = ui.GetInput();
            var split_Args = cmdArgs.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string thridWord = split_Args[2];
            string s = $"The third words is: {thridWord}. (Please buy tickets)";
            ui.Print(s);

        }

        private static void RepeatTenTimes()
        {
            ui.Print("Please enter a Text, the program will auto-magically repeat it 10 times!");
            string answer = ui.GetInput();
            int length = 10;
            for (int i = 0; i < length; i++)
            {
                ui.PrintWrite(answer);             
            }
        }

        private static void PrintTicketPrices()
        {
            CinemaGoer[] partyMembers = party.GetMembers();

            int total = 0;
            foreach (CinemaGoer partyMember in partyMembers)
            {
                ui.Print(partyMember.ToString());
                total += partyMember.TicketPrice;
            }
            string s = $"The Total cost for the party is: {total.ToString()}";
            ui.Print(s);
        }

        private static void AddCinemaGoer()
        {
            do
            {

                ui.Print("Please Enter the Age of Cinema goer. Q to Exit");
                string age = Utils.AskForString("Enter Age: ", ui);
                if ((age.ToLower().Equals("q"))) break;

                int intAge = Utils.ParseInt(age, ui);
                if(intAge >= 0)
                {
                    CinemaGoer member = new(intAge);
                    party.AddMember(member);
                }                

            } while (true);
        }

        private static void ShowMainMenu()
        {
            ui.Print(" ");
            ui.Print("Type 0 to close the program");
            ui.Print("Type 1 to Enter Cinema goer's Age"); // Better How Many Tickets --> How many are this age... But math..
            ui.Print("Type 2 to try Awsome Cinema Functionality (repeat 10 times)");
            ui.Print("Type 3 to Print Ticket Prices");
            ui.Print("Type 4 Try our SPLIT Functionality");
        }



    }
}
