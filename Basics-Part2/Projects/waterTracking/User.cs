using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningSpace//.Basics_Part2.Projects.waterTracking
{
    class User
    {
        public User(string firstName, string lastName) // constructor
        {
            FirstName = firstName;
            LastName = lastName;
            WaterEntries = new List<Day>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Day> WaterEntries { get; set; }
        public int PercentOfTodaysGoal => WaterEntries.Where(x => x.Date == DateTime.Today).FirstOrDefault().TotalWater * 100 / WaterGoal;
        public int WaterGoal { get; set; }
        public int DaysAchieveWaterGoal { get; set; } // will be utilized in future when DB is added

        public void AddWaterEntry(Day day)
        {
            WaterEntries.Add(day);
        }
    }
}
