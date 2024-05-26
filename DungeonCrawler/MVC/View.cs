using DungeonCrawler.Items;
using DungeonCrawler.MVC;
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
            Console.Write("\n");

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

        public char RoomDescription(Map map)
        {
            bool b;
            string roomName;
            int throaway1, throwaway2;
            (b, throaway1, throwaway2,roomName) = map.CurrentRoom();

            Console.WriteLine(roomName);
            foreach (Room room in map.map_room)
            {
                if (room._name == roomName)
                {
                    Console.WriteLine(room._des);
                }
            }

            Console.WriteLine("N - North \nS - South \nE - East \nW - West");
            Console.Write("\nPlease choose which direction you want to go:");
            return Convert.ToChar(Console.ReadLine());
        }

        public void MoveOptions(char option)
        {
            switch (option)
            {
                case 'N':
                    Console.WriteLine("You moved North");
                    break;
                case 'S':
                    Console.WriteLine("You moved South");
                    break;
                case 'E':
                    Console.WriteLine("You moved East");
                    break;
                case 'W':
                    Console.WriteLine("You moved West");
                    break;
                case 'L':
                    Console.WriteLine("You walk into a wall");
                    break;
                case 'B':
                    Console.WriteLine("You can't move the enemy is right in front of you!");
                break;
                default:
                    Console.WriteLine("Please input a valid cardinal direction..");
                break;
                
            }
        }

        public void NoEnemies()
        {
            Console.WriteLine("There are no Enemies...");
            Console.WriteLine("\n");
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