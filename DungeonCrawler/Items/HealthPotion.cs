using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonCrawler.Items
{
    public class HealthPotion : Item
    {
        Random random = new Random();
        public override string Name => throw new NotImplementedException();
        public override int Use()
        {
            int healing_amount = random.Next(0,25);

            return healing_amount;
        }

        public override void Interact()
        {
            Console.WriteLine("A red liquid bends the light bouncing inside the glassy flask");
        }



    }
}