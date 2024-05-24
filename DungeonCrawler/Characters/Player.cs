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

                _health -= value;
            }          
        }

        public string Name { get; }

        /// <summary>
        /// Constructor for Player
        /// </summary>
        public Player(string name = "Player")
        {
            Name            = name;
            Health              = 100;
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
        /// <param name="amount">the amount of health points to recover</param>
        public void Heal(int amount)
        {
            Health += amount;
        }

        /// <summary>
        /// Deduct Player's Health Points
        /// </summary>
        /// <param name="amount">the amount of health points to deduct</param>
        public void TakeDamage(int amount)
        {
            Health -= amount;
        }

    }
}