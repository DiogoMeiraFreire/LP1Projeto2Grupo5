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

        public string r_item_string;
        public string[] r_items;
        public int r_enemyCount;

        /// <summary>
        /// Parses a file with every room description
        /// </summary>
        public void FileParser()
        {
            //Console.WriteLine($"{FilePath}");
            //foreach (string line in File.ReadLines(@"D:\UNI\4oAno\LP1\LP1Proj2Grupo05\LP1Projeto2Grupo5\DungeonCrawler\testDesc.txt"))
            
            //Logic to dissect the text, can be put in a different method that uses the room name as parameter?
            foreach(string line in File.ReadLines(FilePath))
            {
                if (line.Contains("R_N"))
                {
                    r_name = line.Replace("R_N:", "");
                }
                if (line.Contains("R_Des"))
                {
                    r_des = line.Replace("R_Des:", "");
                }
                if (line.Contains("R_Itm"))
                {
                    //Console.WriteLine(line);
                    r_item_string = line.Replace("R_Itm:", "");
                    r_items = r_item_string.Split('_');
                    //Console.WriteLine(r_item_string);

                }
                if (line.Contains("R_E:"))
                {
                    line.Replace("R_E:", "");
                    r_enemyCount = line.Split('_').Length;
                }
                
            }   
            
        }
        
    }
}