using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DungeonCrawler.Items;

namespace DungeonCrawler
{
    public class Enemy : ICharacter
    {
        public string Name { get; }
        /// <summary>
        /// Health points of a character
        /// </summary>
        public int Health { get; set; }


        /// <summary>
        /// Attack Power of a character
        /// </summary>
        public int AttackPower { get; set; }

        public Enemy(string name = "Enemy")
        {
            Name            = name;
            Health            = 100;
        }

        /// <summary>
        /// Attack action towards a specific target
        /// </summary>
        /// <param name="target"> the target to attack </param>
        public void Attack(ICharacter target)
        {
            target.TakeDamage(this.AttackPower);
        }

      
        //como nao ter de herdar isto      
        public void Heal( HealthPotion potion)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removing health points (also known as taking damage)
        /// </summary>
        /// <param name="amount"> amount of damage to take </param>
        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (this.Health < 0)
            {
                this.Die();
            }   
        }

        public void Die()
        {
             
        }



    }
}