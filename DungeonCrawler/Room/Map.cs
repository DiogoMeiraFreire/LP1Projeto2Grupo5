using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonCrawler.MVC
{
    public class Map
    {
        public int MapY;
        public int MapX;

        public Room[,] map_s;

        /// <summary>
        /// MapX should be Columns, MapY should be rows
        /// </summary>
        /// <param name="mapY">Rows</param>
        /// <param name="mapX">Columns</param>
        public Map(int mapY, int mapX)
        {
            MapY = mapY;
            MapX = mapX;

            map_s = new Room[mapY,mapX];

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
    }
}
