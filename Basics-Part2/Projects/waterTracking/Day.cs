using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningSpace//.Basics_Part2.Projects.waterTracking
{
    class Day
    {
        public Day()
        {
            Date = DateTime.Today;
            WaterEntries = new List<int>();
        }

        public DateTime Date { get; set; }
        public int TotalWater => WaterEntries.Sum();
        public List<int> WaterEntries { get; set; }

        public void AddWaterEntry(int waterEntry)
        {
            WaterEntries.Add(waterEntry);
        }
    }
}
