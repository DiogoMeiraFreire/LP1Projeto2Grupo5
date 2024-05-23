using System;
using Dungeon.Items;
using System.Collections.Generic;

namespace Dungeon
{

    /// <summary>
    /// Interface
    /// </summary>
    public interface IView
    {
        
        /// <summary>
        /// Welcome Message
        /// </summary>
        void Welcome();

        /// <summary>
        /// Shows the menu
        /// </summary>
        /// <returns></returns>
        int ShowMenu();

        /// <summary>
        /// Shows the inventory
        /// </summary>
        /// <param name="inventory"> a list of the inventory items </param>
        /// <returns></returns>
        int ShowInventory(List<Item> inventory);


        /// <summary>
        /// Used to display a string as a parameter
        /// </summary>
        /// <param name="message"> String to display </param>
        void NewLineMessage(string message ="");


        /// <summary>
        /// Should be used to display a integer message.
        /// </summary>
        /// <param name="message">
        /// Integer to display
        /// </param>
        void LineMessage(string message);


        string ReadInput();


        /// <summary>
        /// Used to wait for a key to be pressed
        /// </summary>
        void WaitForKey();

        /// <summary>
        /// Used to display an error message
        /// </summary>
        /// <param name="message"></param>
        void ErrorMessage(string message);


        /// <summary>
        /// Displays the final message
        /// </summary>
        void EndMessage();
        
        
    }
}