using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace
{
    //not working water tracker
    class WaterTracker2
    {
        static int addWater = 0;
        public void Run()
        {
            //Ask user for goal amount of water to drink for a day
            Console.WriteLine("Please set your daily water intake goal in ounces.");
            string stringDaily = Console.ReadLine();
            int dailyGoal = int.Parse(stringDaily);

            bool continueTracking = true;
            while (continueTracking)
            {
                //Allow user to keep entering amount of water they drink
                string stringInputWater = Console.ReadLine();
                int inputWater = int.Parse(stringInputWater);
                addWater += inputWater;
                //If they are below or above daily amount print out by how much
                if (addWater < dailyGoal)
                {
                    int remainingWater = dailyGoal - addWater;
                    Console.WriteLine($"You have {remainingWater} ounces left to drink");
                }
                else if (addWater > dailyGoal)
                {
                    int surplusWater = addWater - dailyGoal;
                    Console.WriteLine($"You are {surplusWater} ounces over your goal!");
                }
                //Print running count of how much they drank
                //Allow user to stop program
                Console.WriteLine("Say STOP when finished.");
                string stopTracking = Console.ReadLine().ToUpper();
                if (stopTracking == "STOP")
                {
                    continueTracking = false;
                }
            }
        }
    }
}
