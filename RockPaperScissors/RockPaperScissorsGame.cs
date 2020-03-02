using System;

namespace RockPaperScissors
{
    public class RockPaperScissorsGame
    {
        private Random rng;
        private int wins;
        private int losses;
        private int ties;

        public RockPaperScissorsGame()
        {
            rng = new Random();
        }

        public void Play()
        {
            string userChoice;
            userChoice = PromptUser();

            while (userChoice != "Q")
            {
                //do stuff to play gamee
                //Console.WriteLine("We be palyin");

                string computerChoice = GetComputerChoice();
                userChoice = PromptUser();
            }
        }

        private string GetComputerChoice()
        {
            int choice = rng.Next(1, 4);

            if (choice == 1)
                return "R";
            else if (choice == 2)
                return "P";
            else
                return "S";
        }

        private string PromptUser()
        {
            while(true)
            {
                Console.WriteLine("Enter your choice (R)ock, (P)aper, (S)cissors, or (Q)uit: ");
                string choice = Console.ReadLine();

                if (choice == "R" || choice == "P" || choice == "S" || choice == "Q")
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("That was not a valid choice!");
                }
            } 
        }
    }
}
