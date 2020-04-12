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
            Console.WriteLine("How many bags would you like?");
            string sBagNum = Console.ReadLine();
            int bagNum = int.Parse(sBagNum);
            var bags = MakeBags(bagNum);
            bool keepFilling = true;
            while (keepFilling == true)
            {
                // Ask user which bag they would like to fill with marbles
                Console.WriteLine($"Choose a bag to fill between 1 and {bagNum}");
                string sBagChoice = Console.ReadLine();
                int bagChoice = int.Parse(sBagChoice);

                // Allow for input

                // Ask user how many marbles they would like to put in bag
                Console.WriteLine("How many marbles would you like to put in this bag?");
                string sNumMarbles = Console.ReadLine();
                int numMarbles = int.Parse(sNumMarbles);
                FillBag(bags[bagChoice - 1], numMarbles);
                // Ask if they want to continue or stop
                Console.WriteLine("Would you like to fill another bag? (Y/N)");
                string sContinue = Console.ReadLine();
                if (sContinue != "Y")
                {
                    keepFilling = false;
                }
            }
            // Print out list of marbles in bag
            int count = 0;
            foreach (var bag in bags)
            {
                Console.WriteLine($"Bag {count + 1} has {bag.Count} marbles in it.");
                foreach (var marble in bags)
                {
                    Console.WriteLine(count);
                    count++;
                }
            }
        }
        public void FillBag(List<string> bag, int numMarbles)
        {
            string[] colors = new string[] { "pink", "blue", "purple", "orange" };
            Random rnd = new Random();
            for (int i = 0; i < numMarbles; i++)
            {
                int randomNum = rnd.Next(0, colors.Length);
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
