using System;

namespace multifabriken_niklas_frangi
{
    class Menu
    {
        public void printMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("1. Beställ bil.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("2. Beställ godis.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("3. Beställ snöre.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("4. Beställ tofu.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("5. Lista alla beställda produkter.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("6. Avsluta programmet.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.Write("Skriv här: ");
        }
    }
}