using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Basics_Part2.HomeWork.Hw3
{
    public class Player
    {
        // Put this class into a new file
        // Add a property for user choice such as rock, paper, or scissors

        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Choice { get; set; }
    }
}
