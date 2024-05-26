using DungeonCrawler.Characters;

namespace DungeonCrawler
{
    public class Model
    {

        private Player  player;

        public Player   Player => player;

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
    }
}