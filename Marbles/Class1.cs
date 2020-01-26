﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Marbles
{
    class Class1
    {
        static void Main()
        {
            //Prompt to ask for number of bags
            Console.WriteLine("How many bags of marbles would you like?");
            string stringNumBags = Console.ReadLine();
            int numBags = int.Parse(stringNumBags);
            var bags = numberOfBags(numBags);
            //ask which bag they would like to choose
            Console.WriteLine($"Choose a bag between 1 and {numBags}");
            string stringBagChoice = Console.ReadLine();
            int bagChoice = int.Parse(stringBagChoice);
            //ask how many marbles 
            Console.WriteLine("How many marbles would you like in this bag?");
            string marbleNum = Console.ReadLine();
            int numOfMarbles = int.Parse(marbleNum);
            fillBag(bags[bagChoice -1], numOfMarbles);

            //prompt giving the color of marbles

            //prompt asking if user would like to continue
        }
        public static void fillBag(List<string> bag, int numOfMarbles)
        {
            string[] colors = new string[] { "red", "blue", "green", "pink" };
            Random rnd = new Random();
            for (int i = 0; i <numOfMarbles; i++)
            {
                int randomNum = rnd.Next(0, 4);
                string color = colors[randomNum];
                bag.Add(color);
                Console.WriteLine($"Marble {i + 1} is {color}.");
            }
        }
        public static List<List<string>> numberOfBags(int num)
        {
            var bags = new List<List<string>>();
            for (int i = 0; i < num; i++)
            {
                List<string> bag = new List<string>();
                bags.Add(bag);
            }
            return bags;
        }
    }
}
