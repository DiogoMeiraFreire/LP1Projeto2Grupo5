using System;
using DungeonCrawler.MVC;

namespace DungeonCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Map map= new Map(6, 6);

            map.FillMap();
        }
    }
           
        
        
}
