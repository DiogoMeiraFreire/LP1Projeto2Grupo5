using DungeonCrawler.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DungeonCrawler
{
    public class Player : ICharacter
    {
        private int _health; 

        /// <summary>
        /// Health property for Player
        /// </summary>
        public int Health {

            get { return _health; }


            set 
            { 
                if(_health <= 0)
                {  
                    
                }

                _health = value;
            }          
        }

        public string Name { get; }

        /// <summary>
        /// Constructor for Player
        /// </summary>
        public Player(string name = "Player")
        {
            Name            = name;
            Health            = 100;
        }

         /// <summary>
        /// AttackPower property
        /// </summary>
        public int AttackPower { get ; set; }

        //To complete and summarize
        public void Attack(ICharacter target)
        {

        }

        /// <summary>
        /// Recover Player's Health Points
        /// </summary>
        /// <param name="healthPotion">a health potion that the player can use.</param>
        public void Heal(HealthPotion healthPotion)
        {
            Health += healthPotion.Use();
        }

        /// <summary>
        /// Deduct Player's Health Points
        /// </summary>
        /// <param name="amount">the amount of health points to deduct</param>
        public void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public void Die()
        {
            throw new NotImplementedException();
        }

    }
}