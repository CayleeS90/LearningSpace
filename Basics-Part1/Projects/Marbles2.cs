using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace
{
    class Marbles2
    {
        public void Run()
        {
            // Ask user how many bags of marbles they would like
            Console.WriteLine("How many bags of marbles would you like?");
            string sNumBags = Console.ReadLine();
            int numBags = int.Parse(sNumBags);
            var bags = MakeBags(numBags);
            bool keepFilling = true;
            while (keepFilling == true)
            {
                // Ask user which bag they would like to fill with marbles
                Console.WriteLine($"Choose a bag between 1 and {numBags} to fill with marbles?");
                string sBagChoice = Console.ReadLine();
                int bagChoice = int.Parse(sBagChoice);
                // Allow for input

                // Ask user how many marbles they would like to put in bag
                Console.WriteLine("How man marbles would you like to put in the bag?");
                string sNumMarbles = Console.ReadLine();
                int numMarbles = int.Parse(sNumMarbles);
                FillBag(bags[bagChoice - 1], numMarbles);
                // Ask if they want to continue or stop
                Console.WriteLine("Would you like to continue?(Y/N)");
                string sContinue = Console.ReadLine().ToUpper();
                if (sContinue != "Y")
                {
                    keepFilling = false;
                }
            }
            // Print out list of marbles in bag
            Console.WriteLine($"The contents of the bag are:");
        }
        public void FillBag(List<string> bag, int numMarbles)
        {
            string[] colors = new string[] { "pink", "blue", "red", "yellow" };
            Random rnd = new Random();
            for (int i = 0; i < numMarbles; i++)
            {
                int randomNum = rnd.Next();
                string color = colors[randomNum];
                bag.Add(color);
                Console.WriteLine($"Marble {i + 1} is {color}");
            }
        }
        public List<List<string>> MakeBags(int num)
        {
            var bags = new List<List<string>>();
            for (int i = 0; i < num; i++)
            {
                var bag = new List<string>();
                bags.Add(bag);
            }
            return bags;
        }
    }
}
