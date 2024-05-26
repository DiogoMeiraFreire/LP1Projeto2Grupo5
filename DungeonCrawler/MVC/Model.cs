using System;
using DungeonCrawler.Characters;


namespace DungeonCrawler
{
    public class Model
    {

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

        public void MenuLogic(View view)
        {
            switch(view.ShowMenu())
            {
                case 1:
                    Move();
                    break;
                case 2:
                    Attack();
                    break;

                case 3:
                    ItemInventory();
                    break;

                case 4:
                    Menu();
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