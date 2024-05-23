using System;
using System.IO;
using System.Collections.Generic;
using Dungeon.Items;
using Dungeon.Characters;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Dungeon
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
            
        public bool EndGame()
        {
            return player.Hp <= 0;
        }

    
    }
}