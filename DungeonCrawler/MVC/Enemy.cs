using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    public class Enemy : ICharacter
    {
               /// <summary>
        /// Health points of a character
        /// </summary>
        public int Health { get; set; }


        /// <summary>
        /// Attack Power of a character
        /// </summary>
        public int AttackPower { get; set; }

        /// <summary>
        /// Attack action towards a specific target
        /// </summary>
        /// <param name="target"> the target to attack </param>
        public void Attack(ICharacter target)
        {

        }

        /// <summary>
        /// Heal action with an amount variable
        /// </summary>
        /// <param name="amount"> amount of health to recieve </param>
        public void Heal(int amount)
        {

        }

        /// <summary>
        /// Removing health points (also known as taking damage)
        /// </summary>
        /// <param name="amount"> amount of damage to take </param>
        public void TakeDamage(int amount)
        {

        }


    }
}