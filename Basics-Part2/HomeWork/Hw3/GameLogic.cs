using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LearningSpace.Basics_Part2.HomeWork.Hw3
{
    public class GameLogic
    {
        // Put this class into a new file
        // Put all Console.ReadLine and Console.WriteLine methods into different methods under the GameLogic class
        // Put all logic to determine the winner here
        static int userWins = 0;
        static int compWins = 0;
        public void StartGame()
        {
            Console.WriteLine("Would you like to play Rock Paper Scissors?");

            var continueGame = true;
            while(continueGame)
            {

                Console.WriteLine("Select a number of your choice: \n 1. Rock \n 2. Paper \n 3. Scissors");

                var choices = new string[] { "Rock", "Paper", "Scissors" };
                var userChoice = int.Parse(Console.ReadLine()) - 1;

                Random rnd = new Random();
                var compChoice = rnd.Next(0, 3);

                Console.WriteLine($"You chose {choices[userChoice]}");
                Console.WriteLine($"Computer chose {choices[compChoice]}");

                if (userChoice == compChoice) Console.WriteLine("Draw!");
                else if ((userChoice == 1 && compChoice == 0) || (userChoice == 0 && compChoice == 2) || (userChoice == 2 && compChoice == 1))
                {
                    Console.WriteLine("User wins!"); userWins += 1;
                }
                else Console.WriteLine("Computer Wins!"); compWins += 1;

                Console.WriteLine($"User has won {userWins} times. Computer has won {compWins} times");

                Console.WriteLine("Would you like to continue playing? (Y/N)");
                var playAgain = Console.ReadLine().ToUpper();
                if (playAgain != "Y") continueGame = false;
            }
        }
    }
}
