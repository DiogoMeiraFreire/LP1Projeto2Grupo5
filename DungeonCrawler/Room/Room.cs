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
        //public string r_iD;

        public Room(string filePath)
        {
            FilePath = filePath;
        }
        public string r_name;
        public string R_name;

        public string r_des;
        public string R_des;

        private string r_item_string;
        public string[] r_items;
        public string[] R_items;
        public int r_enemyCount;
        public int R_enemyCount;

        List<object> Room_entities = new List<object>();
        List<object> room_entities= new List<object>();

        public Room()
        {
            R_name = r_name;
            R_des = r_des;
            R_items = r_items;
            R_enemyCount = r_enemyCount;
            Room_entities = room_entities;

        }
        

        /// <summary>
        /// Parses the room txt file to gather the information necessary for that specific instance of a room
        /// </summary>
        /// <param name="r_iD">Room ID (should come from map array)</param>
        public void FileParser(string r_iD)
        {
            r_name = r_iD;
            foreach(string line1 in File.ReadLines(FilePath))
            {
                if (line1.Contains(r_iD))
                {
                
                    //Logic to dissect the text, can be put in a different method that uses the room name as parameter?
                    foreach(string line in File.ReadLines(FilePath))
                    {
                        /*if (line.Contains("R_N"))
                        {
                            r_name = line.Replace("R_N:", "");
                        }*/
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

        public void EntityPopulator()
        {
           foreach(string i in R_items)
           {
            Room_entities.Add(i);
           }
           for(int i = 0; i < R_enemyCount; i++)
           {
            Enemy enemy = new Enemy();
            Room_entities.Add(enemy);
           }
        } 

        //unecessary (possibly)
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

        //unecessary (possibly)
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