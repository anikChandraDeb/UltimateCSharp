using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class ConsoleClass
    {
        public void PracticeConsole()
        {
            // Writing to the console
            Console.Write("Hello,"); //Print in console without new line
            Console.WriteLine(" introduce yourself"); //Print in console with new line
            Console.WriteLine("Enter your name:");
            // Reading from the console
            string name = Console.ReadLine();
            // Displaying a greeting message
            Console.WriteLine("Hello, " + name + "! Welcome to C# programming.");
            Console.ReadKey(); // Waits for a key press before closing the console window

            Console.Clear(); // Clears the console
            Console.Beep(); // Makes a beep sound
            Console.WriteLine("Console cleared. Press any key to exit.");
        }
    }
}
