using System;
using DungeonCrawler.Items;
using DungeonCrawler.MVC;
using System.IO;
using System.Security.Principal;

namespace DungeonCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            //Map test code
           /* Map map= new Map(6, 6);

            map.FillMap();*/
            
            //HealthPotion use test code
            /*Player player= new Player("HomieI");
            HealthPotion potion = new HealthPotion();

            player.Heal(potion);

            Console.WriteLine($"{player.Health}");

            player.Heal(potion);

            Console.WriteLine($"{player.Health}")*/


            string fileName = @"testDesc.txt";

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
            Console.WriteLine(FilePath);

            Room room = new Room(FilePath);
            
            
            if (!File.Exists(FilePath) || new FileInfo(FilePath).Length == 0)
            {
                room.CreateFile(FilePath);
            }


            room.FileParser("C2");
            room.EntityPopulator();

            Console.WriteLine($"{room.r_name}");
            Console.WriteLine(room.r_des);
            foreach(string i in room.r_items)
            {
                Console.WriteLine(i);
            }
            foreach(string i in room.r_enemyCount)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(room.r_potions.Count);
            
            

       }
    }
           
        
        
}
