using System;
using DungeonCrawler.Characters;

namespace DungeonCrawler
{
    public class Controller
    {
        private Player player;
        public void MenuLogic(View view)
        {
            view.Welcome();
            view.WaitForKey();

            switch(view.ShowMenu())
            {
                case 1:
                    //Move();
                    break;
                case 2:
                    //player.Attack(Enemy);
                    break;

                case 3:
                    view.ShowInventory(player.inventory);
                    break;

                case 4:
                    //Menu();
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