using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LearningSpace.Basics_Part2.HomeWork.Hw4
{
    public class Game
    {
        // Put this class into a new file
        // Put all Console.ReadLine and Console.WriteLine methods into different methods under the Game class

        // Put all logic to determine the winner here

        // Refactor any code from Tic Tac Toe that could be shortened or made more re-usable **ask for hint if unsure what section I am talking about
        bool isPlayerOne = true;
        bool isDraw = false;
        bool isWin = false;

        char[] arr;

        public void GameIntro()
        {
            Console.WriteLine("Let's play Tic Tac Toe!");
        }

        public void SetUpBoardData()
        {
            arr = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }

        public void DisplayBoard()
        {
            Console.WriteLine("      |       |      ");
            Console.WriteLine($" {arr[0]}    |  {arr[1]}    |  {arr[2]}  ");
            Console.WriteLine("______|_______|______");
            Console.WriteLine("      |       |      ");
            Console.WriteLine($" {arr[3]}    |  {arr[4]}    |  {arr[5]}  ");
            Console.WriteLine("______|_______|______");
            Console.WriteLine("      |       |      ");
            Console.WriteLine($" {arr[6]}    |  {arr[7]}    |  {arr[8]}  ");
            Console.WriteLine("      |       |      ");
        }

        public void PlayGame()
        {
            while (!isWin && !isDraw)
            {
                if (isPlayerOne == true)
                {
                    Console.WriteLine("Player one choose a number.");
                    int numInput = int.Parse(Console.ReadLine());
                    arr[numInput - 1] = 'x';
                    isPlayerOne = false;
                    DisplayBoard();
                }
                else
                {
                    Console.WriteLine("Player two choose a number.");
                    int numInput = int.Parse(Console.ReadLine());
                    arr[numInput - 1] = 'o';
                    isPlayerOne = true;
                    DisplayBoard();
                }

                CheckForWinOrDraw();
            }
        }

        public bool GameOver()
        {
            Console.WriteLine($"Game over. Would you like to play again?");
            
            return Console.ReadLine().ToUpper() != "Y";
        }

        private bool CheckForWin()
        {
            if (arr[0] == arr[3] && arr[0] == arr[6]) return true;
            if (arr[0] == arr[1] && arr[0] == arr[2]) return true;
            if (arr[0] == arr[4] && arr[0] == arr[8]) return true;
            if (arr[1] == arr[4] && arr[1] == arr[7]) return true;
            if (arr[2] == arr[5] && arr[2] == arr[8]) return true;
            if (arr[2] == arr[4] && arr[2] == arr[6]) return true;
            if (arr[3] == arr[4] && arr[3] == arr[5]) return true;
            if (arr[6] == arr[7] && arr[6] == arr[8]) return true;

            return false;
        }

        private bool CheckForDraw()
        {
            foreach (var item in arr)
            {
                if (item != 'x' && item != 'o') return false;
            }

            return true;
        }

        private void CheckForWinOrDraw()
        {
            isWin = CheckForWin();
            isDraw = CheckForDraw();
        }
    }
}
