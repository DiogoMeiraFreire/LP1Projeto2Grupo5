using System;
using DungeonCrawler.Items;
using DungeonCrawler.MVC;
using System.IO;

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


            string filePath = @"D:\UNI\4oAno\LP1\LP1Proj2Grupo05\LP1Projeto2Grupo5\DungeonCrawler\testDesc.txt";
            Room room = new Room(filePath);

            room.FileParser();

            Console.WriteLine($"{room.r_name}");
            Console.WriteLine(room.r_des);
            foreach(string i in room.r_items)
            {
                Console.WriteLine(i);
            
            }
            Console.WriteLine(room.r_enemyCount);
            
            

       }
    }
           
        
        
}
