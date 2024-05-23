using System;
using System.Collections.Generic;
using DungeonCrawler.Items;

namespace DungeonCrawler
{
    public class Player : ICharacter
    {


        private int _hp; 

        /// <summary>
        /// Hp property for the Player
        /// 
        /// </summary>
        /// <value>
        /// Passed value will be subtracted from the current agent Hp 
        /// Use of the property without setting a value will return the current Hp value of Traveler agent
        /// </value>
        public int Hp {

            get { return _hp; }


            set { 
                if(_hp <= 0)
                {  
                    // kill 
                }

                _hp -= value;
            }          
        }

        public string Name { get; }

        /// <summary>
        /// Constructor for the Traveler Enemy
        /// </summary>
        public Player(string name = "Player")
        {
            Name            = name;
            Hp              = 100;
        }

         /// <summary>
        /// AttackPower property for the Traveler enemy
        /// Read-only property set to 50 by default
        /// </summary>
        /// <value></value>
        public int AttackPower { get ; set; }

        //To complete and summarize
        public void Attack(ICharacter target)
        {

        }

        public void Heal(int amount)
        {
            Hp += amount;
        }

        public void TakeDamage(int amount)
        {
            Hp -= amount;
        }

    }
}