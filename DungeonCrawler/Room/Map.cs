using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace DungeonCrawler.MVC
{

    
    public class Map
    {
        string fileName = @"RoomDescriptions.txt";

        // Get the directory and remove a part of if to avoid conflicts
        static  string projectDirectory = Directory.GetCurrentDirectory();
        static string stringToRemove = @"\bin\Debug\net6.0";
        private int index = projectDirectory.IndexOf(stringToRemove);
       
       
        public int MapY;
        public int MapX;

        public Room[,] map_1;
        public string[,] map_2;

        /// <summary>
        /// MapX should be Columns, MapY should be rows
        /// </summary>
        /// <param name="mapY">Rows</param>
        /// <param name="mapX">Columns</param>
        public Map(int mapX, int mapY)
        {
            MapY = mapY;
            MapX = mapX;

            map_1 = new Room[mapX, mapY];

            map_2 = new string[mapX, mapY];

            FillMap();

        }
        
        //j sao colunas i sao rows
        public void FillMap() 
        {
            for (int i = 0; i < MapX ; i++)
            {
                for (int j = 0 ; j < MapY ; j++)
                {
                    map_2[i , j] = $"{(char)('A' + j)}{i + 1}";
                    Room room = new Room(GetFile(),map_2[i,j]);
                    map_1[i,j] = room;
                }
            }

            
        }

        /// <summary>
        /// fills map with A1-F6
        /// </summary>
        /* public void FillMap()
        {
            
            //fills the map
            for(int i = 0; i < MapX; i++)
            {
                //fills map with A-F
                switch(i)
                    {
                        case 0:
                            for(int y = 0; y < MapX; y++){ map_s[i,y] = "A";}
                            break;
                        case 1:
                            for(int y = 0; y < MapX; y++){ map_s[i,y] = "B";}
                            break;
                        case 2:
                            for(int y = 0; y< MapX; y++){ map_s[i,y] = "C";}
                            break;
                        case 3:
                            for(int y = 0; y< MapX; y++){ map_s[i,y] = "D";}
                            break;
                        case 4:
                            for(int y = 0; y< MapX; y++){ map_s[i,y] = "E";}
                            break;
                        case 5:
                           for(int y = 0; y< MapX; y++){ map_s[i,y] = "F";}
                            break;
                    }
                
                ////fills map with 1-6
                for (int j = 0; j < MapY; j++)
                {
                    switch(j)
                    {
                        case 0:
                            map_s[i,j]  += "1";
                            break;
                        case 1:
                            map_s[i,j]  += "2";
                            break;
                        case 2:
                            map_s[i,j]  += "3";
                            break;
                        case 3:
                            map_s[i,j]  += "4";
                            break;
                        case 4:
                            map_s[i,j]  += "5";
                            break;
                        case 5:
                            map_s[i,j]  += "6";
                            break;
                    }
                    
                }

                
            }
            
            foreach(string s in map_s)
            {
                Console.WriteLine(s);
            }
        } */
    
        public Room CurrentRoom()
        {
            return null;
        }

        public string GetFile()
        {
            if(index >= 0)
            {
                projectDirectory = projectDirectory.Remove(index,stringToRemove.Length);
                string FilePath = Path.Combine(projectDirectory, fileName);
                return FilePath;
            }
            else
            {
                string FilePath = Path.Combine(projectDirectory, fileName);
                return FilePath;
            }
        }
    }
}
