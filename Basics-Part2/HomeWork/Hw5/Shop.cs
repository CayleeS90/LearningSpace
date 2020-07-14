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
            Console.WriteLine("Welcome to my shop!\n");
        }

        public void PrintInventory()
        {
            Console.WriteLine($"The shop has the following items:\n");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"{item.Name} costs {item.Cost} gold which is {item.Rarity} \n");
            }
        }

        public void ThankYou()
        {
            Console.WriteLine("\nThank you! Would you like to buy anything else? \n");
        }

        public void PurchaseOrExit()
        {
            Console.WriteLine("Which item interests you? Or type 'exit' to leave.\n");

        }

        public void PrintProfit()
        {
            Console.WriteLine($"\nShop has {Gold} gold now.\n");
        }

        public void PrintExit(Player player)
        {
            Console.WriteLine("\nThanks! Be careful out there.");

            PrintProfit();
            player.PrintInventory();
            player.PrintGold();
        }

        public bool SellItem(string name, Player player)
        {
            //remove item from shop inventory
            //add item to player inventory
            //removing gold from purse
            //adding gold to shop

            if (player.IsAtCapacity)
            {
                Console.WriteLine("\nYou're carrying too much! Discard an item and try again.\n");

                return false;
            }

            Item itemToSell = Inventory.Where(item => item.Name == name).FirstOrDefault();

            if (itemToSell == null)
            {
                Console.WriteLine("\nThat item does not exist, try again.\n");

                return false;
            }

            if (player.Gold > itemToSell.Cost)
            {
                Inventory.Remove(itemToSell);
                player.Inventory.Add(itemToSell);
                player.Gold -= itemToSell.Cost;
                Gold += itemToSell.Cost;
            }

            else
            {
                Console.WriteLine("\nI'm sorry, you can't afford that! Does anything else interest you?\n");

                return false;
            }

            return true;
        }
    }
}
