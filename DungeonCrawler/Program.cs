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

            Room room = new Room(FilePath,"A1");
            
            
            if (!File.Exists(FilePath) || new FileInfo(FilePath).Length == 0)
            {
                room.CreateFile(FilePath);
            }

            //room test code
            /*
            room.FileParser();
            room.EntityPopulator();

           
            Console.WriteLine($"{room._name}");
            Console.WriteLine(room._des);
            foreach(string i in room._items)
            {
                Console.WriteLine(i);
            }
            foreach(string i in room._enemyCount)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(room._potions.Count);
            Console.WriteLine(room._enemies.Count);
            
            foreach(string i in room._doors)
            {
                Console.WriteLine(i);
            }*/

            //Door Checker test this block will need to be implemented somewhere else
            /*string testName = "A2";
            if (room.DoorChecker(testName) != null && Room.RoomList.Contains(testName) == false)
            {Room C2 = new Room(FilePath, testName);}
            Console.WriteLine(Room.RoomList.Count);*/
            
            
            /*Room B2 = new Room(FilePath,"B2");
            Room C2 = new Room(FilePath,"C2");

            Console.WriteLine(Room.RoomList.Count);
            Console.WriteLine("\n"+room._potions.Count);
            Console.WriteLine(room._enemies.Count);
            Console.WriteLine("\n"+B2._potions.Count);
            Console.WriteLine(B2._enemies.Count);
            Console.WriteLine("\n"+C2._potions.Count);
            Console.WriteLine(C2._enemies.Count);*/

            Player player= new Player("jeremy");

            Console.WriteLine(room._potions.Count);
            player.TakeItem(room,0);

            Console.WriteLine("\n"+room._potions.Count);
            Console.WriteLine(player.inventory.Count);

            player.Heal(0);
            Console.WriteLine("\n"+player.inventory.Count);
            Console.WriteLine(player.Health);
            

       }
    }
           
        
        
}
