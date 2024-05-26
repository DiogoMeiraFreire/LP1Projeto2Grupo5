﻿using System;
using DungeonCrawler.MVC;
using System.IO;
using DungeonCrawler.Characters;


namespace DungeonCrawler
{
    class Program
    {
        static void Main(string[] args)
        {    
            Player player= new Player("Player");
            
            //Map test code
            /*Map map= new Map(6, 6);

            map.FillMap();
            
            //HealthPotion use test code
            HealthPotion potion = new HealthPotion();

            player.UseItem(potion);

            Console.WriteLine($"{player.Health}");

            player.UseItem(potion);

            Console.WriteLine($"{player.Health}");*/


            string fileName = @"RoomDescriptions.txt";

            // Get the directory and remove a part of if to avoid conflicts
            string projectDirectory = Directory.GetCurrentDirectory();
            string stringToRemove = @"\bin\Debug\net6.0";
            int index = projectDirectory.IndexOf(stringToRemove);
            if(index >= 0)
            {
                projectDirectory = projectDirectory.Remove(index, 
                                                        stringToRemove.Length);
            }

            //Combine the current directory with the fileName to get the path
            string FilePath = Path.Combine(projectDirectory, fileName);

            Room room = new Room(FilePath,"C2");
            //room.EntityPopulator();
            
            if (!File.Exists(FilePath) || new FileInfo(FilePath).Length == 0)
            {
                room.CreateFile(FilePath);
            }

            /*Door Checker test this block will need to be implemented somewhere else
            string testName = "A2";
            if (room.DoorChecker(testName) != null && Room.RoomList.Contains(testName) == false)
            {Room C2 = new Room(FilePath, testName);}
            Console.WriteLine(Room.RoomList.Count);
            
            
            Room B2 = new Room(FilePath,"B2");
            Room C2 = new Room(FilePath,"C2");

            Console.WriteLine(Room.RoomList.Count);
            Console.WriteLine("\n"+room._potions.Count);
            Console.WriteLine(room._enemies.Count);
            Console.WriteLine("\n"+B2._potions.Count);
            Console.WriteLine(B2._enemies.Count);
            Console.WriteLine("\n"+C2._potions.Count);
            Console.WriteLine(C2._enemies.Count);

            // Healing Pot Test
            
            Player player= new Player("jeremy");

            Console.WriteLine(room._potions.Count);
            player.TakeItem(room,0);

            Console.WriteLine("\n"+room._potions.Count);
            Console.WriteLine(player.inventory.Count);

            player.Heal(0);
            Console.WriteLine("\n"+player.inventory.Count);
            Console.WriteLine(player.Health);
            
            //Console.WriteLine(room._enemies.Count);
            //Console.WriteLine(room._enemyCount.Length);*/



            Map map= new Map(6,6);

            foreach(string s in map.map_2)
            {
                Console.WriteLine(s);
            }


       }
    }
           
        
        
}
