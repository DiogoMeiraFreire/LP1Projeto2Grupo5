using System;
using DungeonCrawler.Characters;

namespace DungeonCrawler.Items
{
    public class HealthPotion : Item
    {
        Random random = new Random();
        Model model;
        public override string Name => throw new NotImplementedException();
        //private Player player;

        public override void Use()
        {
            int healing_amount = random.Next(0,25);
            model.player.Heal(healing_amount);
        }

        public override void Interact()
        {
            Console.WriteLine("A red liquid bends the light bouncing inside the glassy flask");
        }



    }
}