using System;
using DungeonCrawler.Characters;
using DungeonCrawler.MVC;
namespace DungeonCrawler
{
    public class Controller
    {
        
        static Model model = new Model();

        Player player = model.Player;
        Map map = model.map; 
        public void MenuLogic(View view)
        {
            //view.Welcome();
            //view.WaitForKey();
            (bool bb, int ii, int jj, string rroom_name ) = map.CurrentRoom();
            //Console.WriteLine(map.map_room[ii,jj]._enemies[0].Name);
            Console.WriteLine(map.map_room[ii,jj]._potions.Count);
            Console.WriteLine(map.map_room[ii,jj]._name);
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
                    break;
                case 2:
                    (bool b, int i, int j, string room_name ) = map.CurrentRoom();
                    player.Attack(map.map_room[i, j]._enemies[0]);
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
    }
}