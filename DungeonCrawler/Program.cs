using System;
using DungeonCrawler.MVC;
using System.IO;
using DungeonCrawler.Characters;


namespace DungeonCrawler
{
    class Program
    {
        static void Main(string[] args)
        {    
            Player player= new Player("Player");
            
            Controller controller= new Controller();
            View view = new View();
            Model model = new Model();

            string fileName = @"RoomDescriptions.txt";

            // Get the directory and remove a part of if to avoid conflicts
            string projectDirectory = Directory.GetCurrentDirectory();
            string stringToRemove = @"\bin\Debug\net6.0";
            int index = projectDirectory.IndexOf(stringToRemove);
            if(index >= 0)
            {
                projectDirectory = projectDirectory.Remove(index, 
                                                        stringToRemove.Length);
            }

            //Combine the current directory with the fileName to get the path
            string FilePath = Path.Combine(projectDirectory, fileName);

            Room room = new Room(FilePath,"C2");
            
            if (!File.Exists(FilePath) || new FileInfo(FilePath).Length == 0)
            {
                Console.WriteLine("NO file detected please confirm you have the correct file.");
            }

            controller.C_Welcome();
            controller.MenuLogic();

       }
    }
           
        
        
}
