namespace DungeonCrawler.Items
{
    public abstract class Item
    {
        public abstract string Name { get; }

        /// <summary>
        /// The interaction when picked up
        /// </summary>
        public abstract void Interact();

        /// <summary>
        /// What happens when the item is used
        /// </summary>
        public abstract int Use();
    }
}