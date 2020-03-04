using System;

namespace RockPaperScissors
{
    public class RockPaperScissorsGame
    {
        //variables
        private Random rng;
        private int wins;
        private int losses;
        private int ties;

        public RockPaperScissorsGame()
        {
            rng = new Random();
        }

        //method to play the game
        public void Play()
        {
            string userChoice;
            userChoice = PromptUser();

            while (userChoice != "Q")
            {
                string computerChoice = GetComputerChoice();
                DetermineWinner(userChoice, computerChoice);
                PrintScore();
                Console.Clear();
                userChoice = PromptUser();
            }
        }

        //method to print score
        private void PrintScore()
        {
            Console.WriteLine();
            Console.WriteLine("wins: {0}", wins);
            Console.WriteLine("losses: {0}", losses);
            Console.WriteLine("ties: {0}", ties);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }

            //determines the winner of the round
            private void DetermineWinner(String userChoice, string computerChoice)
            {
                if (userChoice == computerChoice)
                {
                    ties++;
                    Console.WriteLine("You both picked {0}, you tied!", ConvertChoiceToWord(userChoice));
                } 
                else if (userChoice == "R" && computerChoice == "S" || userChoice == "S" && computerChoice == "P" || userChoice == "P" && computerChoice == "R")
                {
                    wins++;
                    Console.WriteLine("You picked {0} and the computer picked {1}, you win! attaboy!", ConvertChoiceToWord(userChoice), ConvertChoiceToWord(computerChoice));
                }
                else 
                {
                    losses++;
                    Console.WriteLine("You picked {0} and the computer picked {1}, you lose! L!", ConvertChoiceToWord(userChoice), ConvertChoiceToWord(computerChoice));
                }
            }

        //gets the computer's choice
        private string GetComputerChoice()
        {
            int choice = rng.Next(1, 4);

            if (choice == 1)
            {
               return "R"; 
            } else if (choice == 2)
            {
              return "P";  
            } else 
            {
                return "S";
            }       
        }

        //converts the letters to actual words. Makes the app cleaner/more understandable
        private string ConvertChoiceToWord(string choice)
        {
            if (choice == "R")
            return "Rock";
            else if (choice == "S")
            return "Scissors";
            else 
            return "Paper";
        }

        //prompts the user
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
