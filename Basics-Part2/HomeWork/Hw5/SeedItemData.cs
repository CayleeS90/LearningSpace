using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSpace.Basics_Part2.HomeWork
{
    public class SeedItemData
    {
        public static List<Item> SeedItems()
        {
            List<Item> items = new List<Item>();

            Item sword = new Item()
            {
                Cost = 100,
                Description = "A plain sword",
                Name = "Sword",
                Rarity = "common"
            };

            Item shield = new Item()
            {
                Cost = 100,
                Description = "Questionable shield",
                Name = "Iffy Shield",
                Rarity = "common"
            };

            Item wand = new Item()
            {
                Cost = 99999,
                Description = "Stupid powerful wand",
                Name = "Ridiculous Wand",
                Rarity = "Legendary"
            };

            items.Add(sword);
            items.Add(shield);
            items.Add(wand);

            return items;
        }

        public static List<Item> SeedPlayerItems()
        {
            List<Item> items = new List<Item>();

            Item potion = new Item()
            {
                Cost = 100,
                Description = "Heals a small amount of health",
                Name = "Health Potion",
                Rarity = "common"
            };

            Item sash = new Item()
            {
                Cost = 100,
                Description = "A belt that holds potions",
                Name = "Sash",
                Rarity = "common"
            };

            Item boots = new Item()
            {
                Cost = 200,
                Description = "Simple leather boots",
                Name = "Boots",
                Rarity = "Common"
            };

            Item lute = new Item()
            {
                Cost = 50,
                Description = "Musical string instrument",
                Name = "Lute",
                Rarity = "Common"
            };

            Item potato = new Item()
            {
                Cost = 50,
                Description = "Roast'em, mash'em, stick'em in a stew",
                Name = "Potato",
                Rarity = "Common"
            };

            items.Add(potion);
            items.Add(sash);
            items.Add(boots);
            items.Add(lute);
            items.Add(potato);

            return items;
        }
    }
}
