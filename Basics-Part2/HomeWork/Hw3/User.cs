using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Basics_Part2.HomeWork.Hw3
{
    public class User
    {
        // Put this class into a new file
        // Add a property for user choice such as rock, paper, or scissors

        public User(string userChoice)
        {
            UserChoice = userChoice;
        }
        public string UserChoice { get; set; }
    }
}
