
using System;

namespace OOPClass
{
    static class Utilities
    {
        // Make a 'ColorfulWriteLine' static method
        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color; // Changes the color of text, from color
            Console.WriteLine(message); // This will display contents of 'message'
            Console.ResetColor(); // This resets the color to default
            
        }
    }
}
