using DungeonCrawler.Items;
using DungeonCrawler.MVC;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;


namespace DungeonCrawler
{
    public class Player : ICharacter
    {
        private int _health; 

        public List<Item> inventory = new List<Item>();

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
            target.TakeDamage(this.AttackPower);
        }

        /// <summary>
        /// Recover Player's Health Points
        /// </summary>
        /// <param name="healthPotion">a health potion that the player can use.</param>
        public void Heal(int value)
        {
            Health += value;
        }

        public void UseItem(int index)
        {
            Item tmpItem = inventory[index];
            tmpItem.Use();
            inventory.RemoveAt(index);
        }

        /// <summary>
        /// Deduct Player's Health Points
        /// </summary>
        /// <param name="amount">the amount of health points to deduct</param>
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
            Console.WriteLine("You died!");
            Environment.Exit(0);
        }

        /// <summary>
        /// A method that lets the player take an item from a room
        /// </summary>
        /// <param name="room">A room that has the item to take (hopefully the room where the player is)</param>
        /// <param name="index">The index of the item inside the room's item list</param>
        public void TakeItem(Room room, int index)
        {
            Item tmpItem;

            if (room._potions.Count > 0 && index <= room._potions.Count)
            {
                tmpItem = room._potions[index];
                room._potions.RemoveAt(index);
                inventory.Add(tmpItem);
            }
            else
            {
                //probably have to make an ask for input method
                return;
            }
        }


    }
}