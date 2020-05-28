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
            Console.WriteLine("Welcome to Rock Paper Scissors");

            var continueGame = true;
            while (continueGame)
            {
                var choices = OfferChoices();
                var _userChoice = UserChoice();
                var _compChoice = CompChoice();

                DetermineWinner(choices, _userChoice, _compChoice);

                Console.WriteLine("Would you like to continue playing? (Y/N)");
                var playAgain = Console.ReadLine().ToUpper();
                if (playAgain != "Y") continueGame = false;
            }
        }
        public string[] OfferChoices()
        {
            Console.WriteLine("Select a number of your choice: \n 1. Rock \n 2. Paper \n 3. Scissors");
            var choices = new string[] { "Rock", "Paper", "Scissors" };

            return choices;
        }
        public int UserChoice()
        {
            var user = new User(int.Parse(Console.ReadLine()) - 1);
            return user.UserChoice;
        }
        public int CompChoice()
        {
            Random rnd = new Random();
            var _compChoice = rnd.Next(0, 3);

            return _compChoice;
        }
        public int DetermineWinner(string[] choices, int _userChoice, int _compChoice)
        {
            Console.WriteLine($"You chose {choices[_userChoice]}");
            Console.WriteLine($"Computer chose {choices[_compChoice]}");

            if (_userChoice == _compChoice) Console.WriteLine("Draw!");
            else if ((_userChoice == 1 && _compChoice == 0) || (_userChoice == 0 && _compChoice == 2) || (_userChoice == 2 && _compChoice == 1))
            {
                Console.WriteLine("User wins!");
                userWins += 1;
            }
            else
            {
                Console.WriteLine("Computer Wins!");
                compWins += 1;
            }
            Console.WriteLine($"User has won {userWins} times. Computer has won {compWins} times");

            return 0;
        }
    }
}
