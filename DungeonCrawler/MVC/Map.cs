using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonCrawler.MVC
{
    public class Map
    {
        public string[,] map_s= new string[6,6];
        
        //fills map with A1-F6
        public void FillMap()
        {
            
            //fills the map
            for(int i = 0; i < 7; i++)
            {

                switch(i)
                    {
                        case 0:
                            for(int y = 0; i < 6; y++){ map_s[i,y] = "A";}
                            break;
                        case 1:
                            for(int y = 0; i < 6; y++){ map_s[i,y] = "B";}
                            break;
                        case 2:
                            for(int y = 0; i < 6; y++){ map_s[i,y] = "C";}
                            break;
                        case 3:
                            for(int y = 0; i < 6; y++){ map_s[i,y] = "D";}
                            break;
                        case 4:
                            for(int y = 0; i < 6; y++){ map_s[i,y] = "E";}
                            break;
                        case 5:
                           for(int y = 0; i < 6; y++){ map_s[i,y] = "F";}
                            break;
                    }
                
                for (int j = 0; j < 7; j++)
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
        }
    }
}
