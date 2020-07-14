using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Basics_Part2.HomeWork
{
    public class Player
    {
        // Put this class into a new file

        // Add properties for name, gold, and inventory

        // Add methods to print out Player's inventory and amount of gold
        public Player(string name, List<Item> playerItems, int gold, int capacity)
        {
            Name = name;
            Inventory = playerItems;
            Gold = gold;
            Capacity = capacity;
        }

        public string Name { get; set; }
        public List<Item> Inventory { get; set; }
        public int Gold { get; set; }
        public int Capacity { get; set; }
        public bool IsAtCapacity => Inventory.Count == Capacity ? true : false;

        public void PrintInventory()
        {
            Console.WriteLine($"{Name} has the following items:\n");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"{item.Name}\n");
            }
        }
        public void PrintGold()
        {
            Console.WriteLine($"{Name} has {Gold} gold now.");
        }
    }
}
