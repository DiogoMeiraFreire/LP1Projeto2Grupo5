namespace DungeonCrawler
{
    public interface ICharacter
    {
        /// <summary>
        /// Health points of a character
        /// </summary>
        int Hp { get; set; }


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
        /// Heal action with an amount variable
        /// </summary>
        /// <param name="amount"> amount of health to recieve </param>
        void Heal(int amount);

        /// <summary>
        /// Removing health points (also known as taking damage)
        /// </summary>
        /// <param name="amount"> amount of damage to take </param>
        void TakeDamage(int amount);

    }
}