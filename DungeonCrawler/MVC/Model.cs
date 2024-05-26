using System;
using DungeonCrawler.Characters;
using DungeonCrawler.MVC;


namespace DungeonCrawler
{
    public class Model
    {
        public Map map = new Map(6,6);
        private Player  player;

        public Player   Player => player;
        public View view = new View();

        public void CreatePlayer(string name)
        {
            if (name != null && name != "")
                player = new Player(name);
            else
                player = new Player("Player");
        }

        public void EntityRemover(object toBeRem)
        {
            toBeRem = null;
        }
            
        public bool EndGame()
        {
            return player.Health <= 0;
        }

        public void Move(char direction)
        {
            
            (bool b, int i, int j, string room_name ) = map.CurrentRoom();
            switch (direction)
            {   
                case 'N':
                    map.PlayerMoveRoom(map.map_room[i-1,j]._name);
                    break;
                case 'S':
                    map.PlayerMoveRoom(map.map_room[i+1,j]._name);
                    break;
                case 'E':
                    map.PlayerMoveRoom(map.map_room[i,j+1]._name);
                    break;
                case 'W':
                    map.PlayerMoveRoom(map.map_room[i,j-1]._name);
                    break;
            }
        }


    }
}