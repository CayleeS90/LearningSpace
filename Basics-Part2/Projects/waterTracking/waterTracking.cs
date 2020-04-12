using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningSpace//.Basics_Part2.Projects Why do I have to remove this part of the namespace for the code to work?
{
    class WaterTracking
    {
        public void Run()
        {
            List<User> currentUsers = new List<User>();

            while (true) 
            {
                Console.WriteLine("Would you like to: \n 1. Add User \n 2. Add water for existing User \n 3. Quit");

                string selection = Console.ReadLine();

                if (selection.Contains("1"))
                {
                    Console.WriteLine("Enter first name:");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Enter last name:");
                    string lastName = Console.ReadLine();

                    // Bonus! Refactor this so the program won't crash if you enter a letter in.  
                    // You should let the user know "not a valid entry" and allow the user to try again
                    Console.WriteLine("Enter water goal in ounces (oz):");
                    int waterGoal = int.Parse(Console.ReadLine()); 

                    User user = new User(firstName, lastName);
                    user.WaterGoal = waterGoal;
                    user.FirstName = "Caylee";
                    var name = user.FirstName;

                    currentUsers.Add(user);
                }
                else if (selection.Contains("2"))
                {
                    Console.WriteLine("Select your user:");

                    for (int i = 0; i < currentUsers.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {currentUsers[i].FirstName} {currentUsers[i].LastName}");
                    }

                    int userId = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Enter water amounts. Enter STOP when done.");
                    Day day = new Day();

                    while (true)
                    {
                        if (!int.TryParse(Console.ReadLine(), out int result)) /// what's happening here?
                            break;

                        day.AddWaterEntry(result);
                        currentUsers[userId].AddWaterEntry(day);
                    }

                    Console.WriteLine($"{currentUsers[userId].FirstName} " +
                        $"drank {currentUsers[userId].WaterEntries.Where(x => x.Date == DateTime.Today).FirstOrDefault().TotalWater} oz of water.");

                    Console.WriteLine($"You are {currentUsers[userId].PercentOfTodaysGoal}% to your goal for today! \n");
                }
                else
                {
                    break;
                }
            }
        }
    }
}
