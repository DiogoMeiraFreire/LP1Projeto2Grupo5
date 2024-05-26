using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonCrawler.Items;
using DungeonCrawler.MVC;

namespace DungeonCrawler.Characters
{
    public class Enemy : ICharacter
    {
        View view;
        public string Name { get; }
        /// <summary>
        /// Health points of a character
        /// </summary>
        public int Health { get; set; }
        public int L_Index { get;}
        public Room E_room {get;}  
       

        /// <summary>
        /// Attack Power of a character
        /// </summary>
        public int AttackPower { get; set; }

        public Enemy(string name = "Enemy", Room room = null)
        {
            Name            = name;
            Health          = 100;
            AttackPower     = 15;
            E_room = room;
            //L_Index = room.GetIndex(this);
            
        }

        /// <summary>
        /// Attack action towards a specific target
        /// </summary>
        /// <param name="target"> the target to attack </param>
        public void Attack(ICharacter target)
        {
            target.TakeDamage(this.AttackPower);
        }

       /* public void E_index();
        {
            room.ge;
        }*/

        /// <summary>
        /// Removing health points (also known as taking damage) 
        /// </summary>
        /// <param name="amount"> amount of damage to take </param>
        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health <= 0)
            {
                
                E_room._enemies.Clear();
            }   
        }

        public void Die()
        {
            E_room._enemies.Remove(this);
        }
    }
}