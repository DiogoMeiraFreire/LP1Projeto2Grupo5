using DungeonCrawler.Items;
using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    public class View : IView
    {
        private readonly Model _model;  

        public View(Model model)
        {
            _model  = model;

        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to the dungeon!");
        }

        private int choice, tempChoice;

        public int ShowMenu()
        {
            
            Console.WriteLine("1. Move");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Use Item");
            Console.WriteLine("4. Menu");

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


        public string ReadInput()
        {
            return Console.ReadLine();
        }

        public void WaitForKey()
        {
            Console.Write("\nPress any key to continue...");

            Console.ReadKey(true);

            Console.WriteLine("\n");
        }

        public void ErrorMessage(string message ="")
        {
            if (message.Length <= 0) Console.WriteLine("Unkown Error");

            Console.WriteLine(message);
            
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