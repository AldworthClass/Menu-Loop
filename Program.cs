using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Menu Option 1");
                Console.WriteLine("2 - Menu Option 2");
                Console.WriteLine("...");
                Console.WriteLine("x - Menu Option x");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                if (choice == "1")
                {
                    //Do option 1
                }
                else if (choice == "2")
                {
                    // Do option 2
                }
                // Add an else if for each valid choice
              
                else
                    Console.WriteLine("Invalid choice");
            }
            // We are outside the menu

        }
    }
}
