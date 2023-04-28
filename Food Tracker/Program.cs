using System;
using System.Collections.Generic;

namespace Food_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            UserProfile.Strart();
            Console.ReadKey();
        }
    }
}
