using System;
using System.Collections.Generic;
using System.IO;
using DungeonCrawler.Items;
using DungeonCrawler.Characters;

namespace DungeonCrawler.MVC
{
    public class Room
    {
        //public string filepath = "D:\UNI\4oAno\LP1\LP1Proj2Grupo05\LP1Projeto2Grupo5\DungeonCrawler\testDesc.txt";
        
       
        public string FilePath{ get;}
        public string R_iD{get;}

        public static List<string> RoomList = new List<string>();

        public Room(string filePath, string r_iD)
        {
            FilePath = filePath;
            R_iD = r_iD;

            R_items = _items;
            R_enemyCount = _enemyCount;
            RoomList.Add(this.R_iD);    

            FileParser();
            EntityPopulator();
        }

        public string _name;
        public string _des;
        private string r_item_string;
        public string[] _items;
        private string[] R_items;
        public List<HealthPotion> _potions= new List<HealthPotion>();
        private string _enemyCount_string;
        public string[] _enemyCount;
        private string[] R_enemyCount;
        public List<Enemy> _enemies= new List<Enemy>();
        private string _doors_string;
        public string[] _doors;
        


        

        /// <summary>
        /// Parses the room txt file to gather the information necessary for that specific instance of a room
        /// </summary>
        /// <param name="r_iD">Room ID (should come from map array)</param>
        public void FileParser()
        {
            _name = R_iD;
          
            //Logic to dissect the text, can be put in a different method that uses the room name as parameter?
            foreach(string line in File.ReadLines(FilePath))
            {
                if (line.Contains(R_iD) && line.Contains("R_Des"))
                {
                    _des = line.Replace(R_iD+"_R_Des:", "");
                }
                if (line.Contains(R_iD) && line.Contains("R_Itm"))
                {
                    r_item_string = line.Replace(R_iD+"_R_Itm:", "");
                    R_items = r_item_string.Split('_');
                }
                if (line.Contains(R_iD) && line.Contains("R_E:"))
                {
                    _enemyCount_string = line.Replace(R_iD+"_R_E:", "");
                    //Console.WriteLine("" + _enemyCount_string);
                    R_enemyCount = _enemyCount_string.Split('_');
                    //Console.WriteLine("" + _enemyCount.Length);
                }
                if (line.Contains(R_iD.ToLower()) && line.Contains("R_D"))
                {
                    _doors_string = line.Replace(R_iD.ToLower()+"_R_D:", "");
                    //Console.WriteLine("\n_doors:"+_doors_string);
                    _doors = _doors_string.Split('_');
                }      
            }
            
        }

        /// <summary>
        /// Populates 2 list that contain the room instance entities (Items Enemies)
        /// </summary>
        public void EntityPopulator()
        {
           if (R_items == null)
           {
            Console.WriteLine("Items array is null. Make sure to call FileParser first.");
            return;
           }
           else
           {
            foreach(string i in R_items)
            {
                HealthPotion potion = new HealthPotion();
                _potions.Add(potion);
            }
           }
           
           if (R_enemyCount == null)
           {
            Console.WriteLine("Enemy array is null. Make sure to call FileParser first.");
            return;
           }
           else
           {
                foreach(string i in R_enemyCount)
                {
                    Enemy enemy = new Enemy(i, this);
                    //enemy.
                    _enemies.Add(enemy);
                }
           }
           
        } 

        /// <summary>
        /// Checks the instance door array to see if the param is valid (maybe this could be in map)
        /// </summary>
        /// <param name="door">Door that will be checked</param>
        /// <returns></returns>
        public bool DoorChecker(string door)
        {
            bool d_check = false;
            foreach(string d in _doors)
            {
                if(d == door){d_check = true;}
            }
            return d_check;
            /* if (d_check == false){return d_check;}
            else{return d_check;} */
        }
        
        public int GetIndex(Enemy enemy)
        {
            int ret;
            ret = _enemies.IndexOf(enemy);
            return ret;
        }

        

        //unecessary (possibly) or a safeguard in case file is deleted



        
    
    }
}