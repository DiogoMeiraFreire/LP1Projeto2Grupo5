using System;
using DungeonCrawler.Characters;
using DungeonCrawler.MVC;
namespace DungeonCrawler
{
    public class Controller
    {
        
        static Model model = new Model();

        Player player = model.player;
        Map map = model.map; 

        View view = model.view;
        public void MenuLogic()
        {
            //view.Welcome();
            //view.WaitForKey();
            //(bool bb, int ii, int jj, string rroom_name ) = map.CurrentRoom();
            //Console.WriteLine(map.map_room[ii,jj]._enemies[0].Name);
           // Console.WriteLine(map.map_room[ii,jj]._potions.Count);
            //Console.WriteLine(map.map_room[ii,jj]._name);
            /* int e_count = 0;
            foreach(Room r in map.map_room)
            {
              e_count += r._enemies.Count;
            }
            Console.WriteLine(e_count);
         */

            switch(view.ShowMenu())
            {
                case 1:
                    model.Move(view.RoomDescription(model.map));
                    MenuLogic();
                    break;
                case 2://failsafe no enemies
                    
                    (bool b, int i, int j, string room_name ) = map.CurrentRoom();
                    if( map.map_room[i,j]._enemies.Count > 0 )
                    {
                    Enemy target =map.map_room[i, j]._enemies[0];
                    //Console.WriteLine(target.Health);
                    player.Attack(target);
                    Console.WriteLine(target.Name+", health:"+target.Health);
                    Console.WriteLine("\n");
                    
                    MenuLogic();
                    }
                    else
                    {
                        view.NoEnemies();
                        MenuLogic();
                    }

                    break;

                case 3:
                    view.ShowInventory(player.inventory);
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                case 0:
                    Console.WriteLine("Unknown choice.\n Please use one of the" + 
                    "provided numbers");
                    view.ShowMenu();
                    break;
            }
        }

        public void C_Welcome()
        {
            view.Welcome();
        }
    }
}