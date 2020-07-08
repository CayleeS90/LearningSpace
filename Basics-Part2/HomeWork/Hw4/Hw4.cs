using LearningSpace;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Basics_Part2.HomeWork
{
    /// <summary>
    /// Classes practice
    /// </summary>
    class Hw4
    {
        public void Main()
        {
            Run r = new Run();
            r.StartGame();
        }
        // -----------------------------------------------------------
        // Re-create the Part 1: Tic Tac Toe project (04) into a Tic Tac Toe game with classes
        // The Tic Tac Toe game is already partially in classes. Now move all Console.ReadLine and Console.WriteLine methods into the Game class
        // -----------------------------------------------------------


        public class Run
        {
            // Do not call any Console.ReadLine or Console.WriteLine methods here
            // Instantiate Game into a variable, and run the game via methods from the Game class only

            public void StartGame()
            {
                Game g = new Game();

                while (true)
                {
                    g.GameIntro();
                    g.SetUpBoardData();
                    g.DisplayBoard();
                    g.PlayGame();
                    g.GameOver();
                }
            }
        }
    }
}
