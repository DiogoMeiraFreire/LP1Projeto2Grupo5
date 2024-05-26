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

        public Room[,] map_room;
        public string[,] map_nams;

        public bool[,] map_player;

        /// <summary>
        /// MapX should be Columns, MapY should be rows
        /// </summary>
        /// <param name="mapY">Rows</param>
        /// <param name="mapX">Columns</param>
        public Map(int mapX, int mapY)
        {
            MapY = mapY;
            MapX = mapX;

            map_room = new Room[mapX, mapY];

            map_nams = new string[mapX, mapY];

            map_player = new bool[mapX, mapY];

            FillMap();
            //starting Room
            PlayerMoveRoom("A2");

        }
        
        //j sao colunas i sao rows
        /// <summary>
        /// This method fills the 3 bi-demensional arrays.
        /// </summary>
        public void FillMap() 
        {
            for (int i = 0; i < MapX ; i++)
            {
                for (int j = 0 ; j < MapY ; j++)
                {
                    map_player[i,j] = false;
                    map_nams[i , j] = $"{(char)('A' + i)}{j + 1}";
                    Room room = new Room(GetFile(),map_nams[i,j]);
                    map_room[i,j] = room;
                }
            }

            
        }


    
        /// <summary>
        /// This method determines where the player is
        /// </summary>
        /// <returns>Touple with room index and name</returns>
        public (bool,int,int,string) CurrentRoom()
        {
            bool tmpB = false;
            int reti = 0;
            int retj = 0;
            
            string room_name = "";

            for (int i = 0; i < MapY ; i++)
            {
                for (int j = 0 ; j < MapX ; j++)
                {
                    if(map_player[i,j] == true)
                    { 
                        reti = i;
                        retj = j;
                        tmpB = true;
                        room_name = map_room[i,j]._name;
                    }
                }
            }
            return (tmpB,reti,retj,room_name);
        }

        /// <summary>
        /// Dictates where the player is, has to be used to update the player location
        /// </summary>
        /// <param name="room_name">Dictates where the player will be</param>
        public void PlayerMoveRoom(string room_name)
        {
            for (int i = 0; i < MapX ; i++)
            {
                for (int j = 0 ; j < MapY ; j++)
                {
                   if(room_name == map_room[i,j]._name)
                   {
                    map_player[i,j] = true;
                   }
                   else
                   {map_player[i,j]= false;}
                }
            }
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
