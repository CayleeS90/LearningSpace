using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace
{ 
    class RockPaperScissors
    {
        static int userWins = 0;
        static int compWins = 0;
        public void Run()
        {
            bool continueGame = true;
            while (continueGame)
            {
                //prompt asking user to play
                Console.WriteLine("Would you like to play Rock Paper Scissors?");
                //prompt offering choices
                Console.WriteLine("Type the number for your selection: \n 1.rock \n 2.paper \n 3.scissors");

                //take in user input
                string[] choices = new string[3] { "rock", "paper", "scissors" };
                string userInput = Console.ReadLine();
                int userChoice = int.Parse(userInput) - 1;
                //random choice from the computer
                Random rnd = new Random();
                int compChoice = rnd.Next(0, 3);
                Console.WriteLine($"You chose {choices[userChoice]}");
                Console.WriteLine($"Computer chose {choices[compChoice]}");
                //determin win
                //print out who won
                if (userChoice == compChoice)
                {
                    Console.WriteLine("Draw");
                }
                else if ((userChoice == 1 && compChoice == 0) || (userChoice == 0 && compChoice == 2) || (userChoice == 2 && compChoice == 1))
                {
                    Console.WriteLine("User wins!");
                    userWins += 1;
                }
                else
                {
                    Console.WriteLine("Computer wins!");
                    compWins += 1;
                }
                //score keeping
                Console.WriteLine($"User has won {userWins} times. Computer has won {compWins} times");
                //prompt for continue
                Console.WriteLine("Do you want to continue? (Y/N)");
                string continueChoice = Console.ReadLine().ToUpper();
                if (continueChoice != "Y")
                {
                    continueGame = false;
                }
            }
        }
    }
}
