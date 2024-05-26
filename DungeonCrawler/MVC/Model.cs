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
            Room room = map.map_room[i,j];
            if (room._enemies.Count != 0)
            {
                view.MoveOptions('B');
            }
            else
            {

                switch (direction)
                {   
                    case 'N':
                        //result is valid if dcheck is true
                        if(i != 0 && map.map_room[i,j].DoorChecker(map.map_room[i-1,j]._name)
                        == true)
                        {
                            map.PlayerMoveRoom(map.map_room[i-1,j]._name);
                            view.MoveOptions('N');
                        }
                        else
                        {
                            view.MoveOptions('L');
                        }
                
                        break;
                    case 'S':
                        if(i != map.MapY && map.map_room[i,j].DoorChecker(map.map_room[i+1,j]._name)
                        == true)
                        {
                            map.PlayerMoveRoom(map.map_room[i+1,j]._name);
                            view.MoveOptions('S');
                        }
                        else
                        {
                            view.MoveOptions('L');
                        }
                        break;
                    case 'E':
                        if(j != map.MapX && map.map_room[i,j].DoorChecker(map.map_room[i,j+1]._name)
                        == true)
                        {
                            map.PlayerMoveRoom(map.map_room[i,j+1]._name);
                            view.MoveOptions('E');
                        }
                        else
                        {
                            view.MoveOptions('L');
                        }
                        break;
                    case 'W'://result is valid if dcheck is true
                        if(j != 0 && map.map_room[i,j].DoorChecker(map.map_room[i,j-1]._name)
                        == true)
                        {
                            map.PlayerMoveRoom(map.map_room[i,j-1]._name);
                            view.MoveOptions('W');
                        }
                        else
                        {
                            view.MoveOptions('L');
                        }
                        break;
                    default:
                        view.MoveOptions('a');
                        break;
                }

                
            }
        }


    }
}