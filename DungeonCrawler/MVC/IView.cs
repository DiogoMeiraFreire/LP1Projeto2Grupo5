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
        int ShowInventory(List<Item> inventory);

        string ReadInput();

        /// <summary>
        /// Used to wait for a key to be pressed
        /// </summary>
        void WaitForKey();


        /// <summary>
        /// Displays the final message
        /// </summary>
        void EndMessage();
        
        
    }
}