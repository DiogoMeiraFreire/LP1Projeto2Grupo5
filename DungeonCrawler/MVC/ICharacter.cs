using DungeonCrawler.Items;
using Microsoft.VisualBasic;

namespace DungeonCrawler
{
    public interface ICharacter
    {
     
        /// <summary>
        /// Health points of a character
        /// </summary>
        int Health { get; set; }


        /// <summary>
        /// Attack Power of a character
        /// </summary>
        int AttackPower { get; set; }

        /// <summary>
        /// Attack action towards a specific target
        /// </summary>
        /// <param name="target"> the target to attack </param>
        void Attack(ICharacter target);
      
        /// <summary>
        /// Removing health points (also known as taking damage)
        /// </summary>
        /// <param name="amount"> amount of damage to take </param>
        public abstract void TakeDamage(int amount);

        public abstract void Die();

    }
}