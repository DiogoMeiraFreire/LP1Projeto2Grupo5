using DungeonCrawler.Items;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DungeonCrawler
{
    public class View : IView
    {
        public void Welcome()
        {
            Console.WriteLine(
            "Welcome to Yet Another Dungeon Crawler, a game where you are thrown"
            + " into a dungeon and your sole purpose is to get out alive. You "
            + "will face Enemies, find hidden Loot and explore this dungeon as"
            + " you try to reach the Exit.\n While entering the different rooms,"
            + " you will get a description of the appearance of room and any"
            + " notable aspect. \n As the player, you have the possibility"
            + " to <Attack> the enemies, move to another room if there is a way"
            + " there with <Move>, items are picked up automatically and use"
            + " any item you have previously picked <Use Item>. \nYou can also"
            + " check your inventory by typing <inventory> and your health with"
            + " <health>.\n");
            
            Console.WriteLine("Welcome to the dungeon!");
        }

        private int choice, tempChoice;

        public int ShowMenu()
        {
            
            Console.WriteLine("1. Move");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Use Item");
            Console.WriteLine("4. Exit game");

            Console.Write("Choose your option: ");

            tempChoice = Convert.ToInt32(Console.ReadLine());

            if(tempChoice == 1 || tempChoice == 2 || tempChoice == 3
              || tempChoice == 4)
            {
                choice = tempChoice;
            }
            else
            {
                choice = 0;
            }

            return choice;
        }

        public int ShowInventory(List<Item> inventory)
        {
            Console.WriteLine("Inventory: ");
            
            int i = 1;
            foreach (Item item in inventory)
            {
                Console.WriteLine($"{i} - {item.Name}");
                i++;
            }

            Console.Write("Choose an item: ");

            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Displays the game's end message
        /// </summary>
        public void EndMessage()
        {
            Console.WriteLine("Game Over");
        }        

    }
}