using DungeonCrawler.Items;
using System.Collections.Generic;

namespace DungeonCrawler
{
    public interface IView
    {
        
        /// <summary>
        /// Welcome Message
        /// </summary>
        void Welcome();

        /// <summary>
        /// Shows the menu
        /// </summary>
        int ShowMenu();

        /// <summary>
        /// Shows the inventory
        /// </summary>
        /// <param name="inventory"> a list of the inventory items </param>
        void ShowInventory(List<Item> inventory);

        /// <summary>
        /// Displays the final message
        /// </summary>
        void EndMessage();
        
        
    }
}