using LearningSpace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learningspace
{
    class Program
    {
        static void Main(string[] args)
        {
            /* PROJECTS */

            Calculator calc1 = new Calculator();
            calc1.Run();

            BlackJackSimple blackJackSimple = new BlackJackSimple();
            blackJackSimple.Run();

            Marbles marbles = new Marbles();
            marbles.Run();

            RockPaperScissors rockPaperScissors = new RockPaperScissors();
            rockPaperScissors.Run();

            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.Run();

            /* HOME WORK */

            HomeWork1 homeWork1 = new HomeWork1();
            homeWork1.Run();

            HomeWork2 homeWork2 = new HomeWork2();
            homeWork2.Run();

            HomeWork3 homeWork3 = new HomeWork3();
            homeWork3.Run();

            WaterTracker waterTracker = new WaterTracker();
            waterTracker.Run();

            WaterTracker2 waterTracker2 = new WaterTracker2();
            waterTracker2.Run();
        }
    }
}