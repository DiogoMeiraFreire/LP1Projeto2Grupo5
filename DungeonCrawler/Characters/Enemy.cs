using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonCrawler.Items;
using DungeonCrawler.MVC;

namespace DungeonCrawler
{
    public class Enemy : ICharacter
    {
        public string Name { get; }
        /// <summary>
        /// Health points of a character
        /// </summary>
        public int Health { get; set; }
        public int L_Index { get;}
        public Room E_room {get;}  
        public Room room;  

        /// <summary>
        /// Attack Power of a character
        /// </summary>
        public int AttackPower { get; set; }

        public Enemy(string name = "Enemy", Room room = null)
        {
            Name            = name;
            Health           = 100;
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

        //como nao ter de herdar isto      
        public void Heal( int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removing health points (also known as taking damage) 
        /// </summary>
        /// <param name="amount"> amount of damage to take </param>
        public void EnemyTakeDamage(int amount)
        {
            Health -= amount;
            if (this.Health < 0)
            {
                this.EnemyDie(room, L_Index);
            }   
        }

        public void EnemyDie(Room room, int index)
        {
             
        }

        public void Die()
        {
            throw new NotImplementedException();
        }
        public void TakeDamage(int i)
        {
            throw new NotImplementedException();
        }




    }
}