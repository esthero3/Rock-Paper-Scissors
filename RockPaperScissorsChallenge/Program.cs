using System;

namespace RockPaperScissorsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Namespace.Class ObjectName = new Namespace.Class()
            //dotnet run RockPaperScissorsChallenge
      RockPaperScissors.RockPaperScissorsGame game = new RockPaperScissors.RockPaperScissorsGame();
      game.Play();
        }
    }
}