using System;
using DungeonCrawler.Items;
using DungeonCrawler.MVC;

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

            Player player= new Player("HomieI");
            HealthPotion potion = new HealthPotion();

            player.Heal(potion);

            Console.WriteLine($"{player.Health}");

            player.Heal(potion);

            Console.WriteLine($"{player.Health}");
        }
    }
           
        
        
}
