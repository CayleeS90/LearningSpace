using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Practice
{
    class Class3
    {
        /// <summary>
        /// This homework is based around if else conditions, collections, and loops.
        ///  It also builds on Hw2 with methods assigned to variables.
        /// </summary>
        class Hw3
        {
            // Below this line, write a method called Add that takes in 4 parameters: 1 List of type string and 3 strings input1, input2, and input 3
            public static List<string> Add(List<string> listOne, string input1, string input2, string input3)
            {
                string[] inputList = new string[] { input1, input2, input3 };
                string inputs = inputList[3];
                listOne.Add(inputs);
                return listOne;
              
            }
            // The method should return a List of type string
            // The method should add all of the strings into the List, and return the List



            //Uncomment the below to debug the DoWork Method to test
            //public static void Main()
            //{
            //    DoWork();
                
            //}

            public static void DoWork()
            {
                // Initialize a new variable of type List of string that is empty called items.
                List<string> items = new List<string>();

                // Initialize 3 new strings with the following values: "sword", "shield", and "potion"
                string sword = "sword";
                string shield = "shield";
                string potion = "potion";

                // Call the Add method you created, and pass in your list + 3 strings and assign it to your items variable.


                // Create an int variable called count, and do items.Count on it


                // Check the value of count? It should be 3. If it isn't see what could have gone wrong. 


                // Add 3 more Swords to your List called items by using your Add() method.


                // *Create a new boolean called IsSword and set it to true


                // *Create a new int called count and set it to 0.


                // *Use a foreach loop to go over your List called items.
                // *When the item is a sword, increase the count by 1


                // Refactor!
                // Comment out your code for all the steps with an asterik (*) on it
                // Create a new method called CountSwords outside of the Main method, it should return an int.
                // Re-write the code from the steps with the asterik (*) in your CountSwords method
                // Create a new int below called numSwords.
                // Your method CountSwords should return the total # of swords it finds and assign it to numSwords.


            }
        }
    }
}
