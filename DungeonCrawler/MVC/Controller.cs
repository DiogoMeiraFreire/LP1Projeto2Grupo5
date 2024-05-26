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
                    
                    player.Attack(target);
                    model.DamageNumb(player, map);
                    target.Attack(player);
                    
                    
                    
                    
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
                    player.UseItem(view.ItemChoice());
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