using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningSpace.Basics_Part2.HomeWork
{

    /// <summary>
    /// Classes practice
    /// </summary>
    class Hw5
    {
        // -----------------------------------------------------------
        // Create a new project called Zelda Shop using classes!!!
        // -----------------------------------------------------------

        public void Main()
        {
            Run();
        }

        public static void Run()
        {
            // Seed the shop with 3 items

            // Seed the player with 5 items in their inventory + 1000 gold

            // Simulate a player entering shop and being welcomed

            // Have console readlines to allow Player (you) to choose items to buy as many items as you want or until shop runs out of items

            // Upon exit of shop, print out shop profit + shop inventory leftover + player gold + player inventory


            Shop shop = new Shop(SeedItemData.SeedItems());

            Player player = new Player("Caylee", SeedItemData.SeedPlayerItems(), 1000, 6);

            shop.PrintWelcome();
            shop.PrintInventory();
            shop.PurchaseOrExit();

            while (true)
            {
                string playerResponse = Console.ReadLine();

                if (playerResponse != "exit")
                {
                    if (shop.SellItem(playerResponse, player))
                    {
                        shop.PrintProfit();
                        player.PrintGold();
                        shop.ThankYou();
                    }
                }

                else
                {
                    shop.PrintExit(player);

                    break;
                }
            }
        }
    }
}
