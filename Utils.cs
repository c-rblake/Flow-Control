using System;

namespace Flow_Control
{
    internal class Utils
    {

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

                else if (string.IsNullOrWhiteSpace(answer))
                {
                    ui.Print("Please enter something");
                }

                else if (n < 0 ^ n > 145) // ^ Or operator
                {
                    ui.Print("Please enter an Age between 0 and 145");
                }
                else if(n > -1 && n < 145) 
                {
                    success = true;
                    break;
                }
                else // Probably will never be used. 
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
                if (int.TryParse(input, out answer)) 
                {
                    ui.Print($"Added a member with age {input}");
                    success = true;
                }
                else
                {
                    ui.Print($"Could NOT add a member with age {input}. Try an age 0 to 145!");
                    return -1;
                }

                // ctrl+k+c to comment ctrl+k+u to uncomment in visual studio

            } while (!success);

            return answer;

        }


    }
}