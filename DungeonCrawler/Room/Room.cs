using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawler.MVC
{
    public class Room
    {
        //public string filepath = "D:\UNI\4oAno\LP1\LP1Proj2Grupo05\LP1Projeto2Grupo5\DungeonCrawler\testDesc.txt";
        
       
        public string FilePath{ get;}

        public Room(string filePath)
        {
            FilePath = filePath;
        }
        public string r_name;
        public string r_des;
        public string[] items;
        public int r_enemyCount;
        public void FileParser()
        {
            Console.WriteLine($"{FilePath}");
            //foreach (string line in File.ReadLines(@"D:\UNI\4oAno\LP1\LP1Proj2Grupo05\LP1Projeto2Grupo5\DungeonCrawler\testDesc.txt"))
            foreach(string line in File.ReadLines(FilePath))
            {
                if (line.Contains("R_N"))
                {
                    r_name = line.Replace("R_N:", "");
                   
                    
                }
            }
            
        }
        
    }
}