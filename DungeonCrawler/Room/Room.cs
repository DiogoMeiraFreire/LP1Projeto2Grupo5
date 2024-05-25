using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

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

        public void CreateFile(string FilePath)
        {            
            //StreamWriter as the AppendText for easier understanding
            //We use "using" here to keep the file open while writting
            //(and because any other way would give errors)
            using(StreamWriter sw = File.AppendText(FilePath))
            {
                //Room identifier
                //A1 just for testing, still need to make the room by order
                //Maybe a function? I'm not sure yet
                sw.WriteLine("R_N:" + "A1");

                //Room Description
                //Chooses random description from the Function RoomDescription
                Random random = new Random();
                sw.WriteLine("R_Des:" + RoomDescription(random.Next(0, 5)));

                //Both of these next ones are just for testing
                //Room Items
                sw.WriteLine("R_Itm:" + "Potion" + "_" + "Book");
                //Room Enemies
                sw.WriteLine("R_E:" + "Enemy");
            }
        }

        public string RoomDescription(int number)
        {
            string description = "";

            switch (number)
            {
                case 0:
                    description = "Room 0";
                break;

                case 1:
                    description = "Room 1";
                break;

                case 2:
                    description = "Room 2";
                break;

                case 3:
                    description = "Room 3";
                break;

                case 4:
                    description = "Room 4";
                break;

                case 5:
                    description = "Room 5";
                break;
            }

            return description;
        }
        
    }
}