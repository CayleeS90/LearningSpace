using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningSpace.Basics_Part2.HomeWork
{
    public class Shop
    {
        // Put this class into a new file

        // Make properties for shop items available to buy, shop profit (gold)

        // Make methods for all shop Prompts such as welcoming Player, listing items for sale, asking player if they want to buy,
        // allowing player to buy items, selling an item, listing shop profit (gold)
        public Shop(List<Item> items)
        {
            Inventory = items;
        }

        public List<Item> Inventory { get; set; }
        public int Gold { get; set; }

        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to my shop!");
        }

        public void PrintInventory()
        {
            Console.WriteLine($"My shop has the following items: \n  ");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"{item.Name} costs {item.Cost} gold which is {item.Rarity} \n");
            }
        }

        public void PurchaseOrExit()
        {
            Console.WriteLine("Which item interests you? Or type 'exit' to leave.");

        }

        public void PrintProfit()
        {
            Console.WriteLine($"Shop has {Gold} gold now \n");
        }

        public void PrintExit(Player player)
        {
            Console.WriteLine("Thanks! Be careful out there.");

            PrintProfit();
            PrintInventory();
            player.PrintInventory();
            player.PrintGold();
        }

        public void SellItem(string name, Player player)
        {
            //remove item from shop inventory
            //add item to player inventory
            //removing gold from purse
            //adding gold to shop

            Item itemToSell = Inventory.Where(item => item.Name == name).FirstOrDefault();
            Inventory.Remove(itemToSell);
            player.Inventory.Add(itemToSell);
            player.Gold -= itemToSell.Cost;
            Gold += itemToSell.Cost;
        }
    }
}
