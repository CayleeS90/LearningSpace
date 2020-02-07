using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Practice
{
    // working water tracker
    class Class5
    {
        static int addWater = 0;
        public static void Main()
        {
            //Ask user for goal amount of water to drink for a day
            Console.WriteLine("Please set your daily water intake goal in ounces.");
            string stringDaily = Console.ReadLine();
            int dailyGoal = int.Parse(stringDaily);
            Console.WriteLine("Say STOP when finished.");
            while (true)
            {
                //Allow user to keep entering amount of water they drink
                string stringInputWater = Console.ReadLine();
                //Allow user to stop program
                string stopTracking = stringInputWater.ToUpper();
                if (stopTracking == "STOP")
                {
                    break;
                }
                int inputWater = int.Parse(stringInputWater);
                addWater += inputWater;
                Console.WriteLine($"You have drank {addWater} ounces so far");
                //If they are below or above daily amount print out by how much
                if (addWater < dailyGoal)
                {
                    int remainingWater = dailyGoal - addWater;
                    Console.WriteLine($"You have {remainingWater} ounces left to drink");
                }
                else
                {
                    int surplusWater = addWater - dailyGoal;
                    Console.WriteLine($"You are {surplusWater} ounces over your goal!");
                }
                //Print running count of how much they drank
            }
            Console.WriteLine($"You have drank {addWater} ounces today.");
        }
    }
}