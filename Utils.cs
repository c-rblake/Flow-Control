using System;

namespace Flow_Control
{
    internal class Utils
    {

        // TWO FUNCTIONS ONE TO DEAL WITH STRINGS ONE TO DEAL WITH INTS. Or Validation becomes very hard

        static Party cinemaparty = new Party();
        internal static string AskForString(string prompt, IUI ui)
            // A tuple would be nice here.
        {
            
            int n;
            bool success = false;
            string answer;
            do
            {
                ui.Print(prompt);
                answer = ui.GetInput();
                int.TryParse(answer, out n);

                if (answer.Equals("Q"))
                {
                    break;
                }

                else if (string.IsNullOrWhiteSpace(answer)) // BREAKS THE PROGRAM
                {
                    ui.Print("Please enter something");
                }

                //if (int.TryParse(answer, out n))
                //{
                //    success = n > -1 && n < 145;
                //    break; // HIGHLANDER
                //}
                else if (n < 0 ^ n > 145) // ^ Or operator
                {
                    ui.Print("Please enter an Age between 0 and 145");
                }
                else if(n > -1 && n < 145)
                {
                    success = true;
                    break;
                }
                else // Probably will never be used. But WHo knows.
                {
                    ui.Print("Please enter an Age between 0 and 145");
                }


            } while (!success);
            //return answer, n;
            return answer;
        }

    
        internal static int ParseInt(string input, IUI ui)
        {
            bool success = false;
            int answer;

            do
            {
                success = int.TryParse(input, out answer); //&& answer > -1 && answer <145; already validated.
                ui.Print($"Added a member with age {input}");

                // ctrl+k+c to comment ctrl+k+u to uncomment in visual studio

            } while (!success);

            return (answer);

        }

    }
}