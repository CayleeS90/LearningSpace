using System;

namespace LearningSpace
{
    class TicTacToe
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Let's play Tic Tac Toe!");
                char[] arr = new char[9]
                {
               '1', '2', '3', '4', '5', '6', '7', '8', '9'
                };
                Game g = new Game();
                g.DisplayBoard(arr);
                bool isPlayerOne = true;
                bool isDraw = false;
                bool isWin = false;
                NewMethod(arr, g, ref isPlayerOne, ref isDraw, ref isWin);
                Console.WriteLine("Game over. Would you like to play again?");
                if (Console.ReadLine().ToUpper() != "Y") break;
            }

        }

        private static void NewMethod(char[] arr, Game g, ref bool isPlayerOne, ref bool isDraw, ref bool isWin)
        {
            while (!isWin && !isDraw)
            {
                if (isPlayerOne == true)
                {
                    Console.WriteLine("Player one choose a number.");
                    string input = Console.ReadLine();
                    int numInput = int.Parse(input);
                    arr[numInput - 1] = 'x';
                    isPlayerOne = false;
                    g.DisplayBoard(arr);
                }
                else
                {
                    Console.WriteLine("Player two choose a number.");
                    string input = Console.ReadLine();
                    int numInput = int.Parse(input);
                    arr[numInput - 1] = 'o';
                    isPlayerOne = true;
                    g.DisplayBoard(arr);
                }
                isWin = g.CheckForDraw(arr);
                isDraw = g.CheckForWin(arr);
            }
        }
    }
    public class Game
    {
        public void DisplayBoard(char[] arr)
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

        public bool CheckForWin(char[] arr)
        {
            if (arr[0] == arr[3] && arr[0] == arr[6]) return true;
            if (arr[0] == arr[1] && arr[0] == arr[2]) return true;
            if (arr[0] == arr[4] && arr[0] == arr[8]) return true;
            if (arr[1] == arr[4] && arr[1] == arr[7]) return true;
            if (arr[2] == arr[5] && arr[2] == arr[8]) return true;
            if (arr[2] == arr[4] && arr[2] == arr[6]) return true;
            if (arr[3] == arr[4] && arr[3] == arr[5]) return true;
            if (arr[6] == arr[7] && arr[6] == arr[8]) return true;
            //if (arr[] == arr[] && arr[] == arr[]) return true;
            return false;

        }
        public bool CheckForDraw(char[] arr)
        {
            foreach (var item in arr)
            {
                if (item != 'x' && item != 'o')
                {
                    return false;

                }
            }
            return true;
        }
    }
}



//    //make array of characters

//    //make board

//    //show user board

//    //ask for user input

//    //boolean for next turn 

//    //check for win

//    //check for draw

