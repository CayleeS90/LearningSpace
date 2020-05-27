using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Basics_Part2.HomeWork.Hw3
{
    /// <summary>
    /// Classes practice
    /// </summary>
    class Hw3
    {
        // -----------------------------------------------------------
        // Re-create the Part 1: Rock Paper Scissors project (03) into a Rock Paper Scissors game with classes
        // -----------------------------------------------------------
        public class Run
        {
            // Do not call any Console.ReadLine or Console.WriteLine methods here
            // Instantiate GameLogic into a variable, and run the game via methods from the GameLogic class only
            public void Main()
            {
                GameLogic gameLogic = new GameLogic();
                gameLogic.StartGame();
            }
        }
    }
}
