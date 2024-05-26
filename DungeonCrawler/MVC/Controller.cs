using System;
using DungeonCrawler.Characters;
using DungeonCrawler.MVC;
namespace DungeonCrawler
{
    public class Controller
    {
        
        static Model model = new Model();

        Player player = model.Player;
        Map viewMap = model.map; 
        public void MenuLogic(View view)
        {
            //view.Welcome();
            //view.WaitForKey();

            switch(view.ShowMenu())
            {
                case 1:
                    model.Move(view.RoomDescription(model.map));
                    break;
                case 2:
                    (bool b, int i, int j, string room_name ) = viewMap.CurrentRoom();
                    player.Attack(viewMap.map_room[i, j]._enemies[0]);
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