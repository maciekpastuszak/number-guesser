using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Zgadywanie liczby";
            int appVersion = 1;
            string appAuthor = "Maciej Pastuszak";

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"[{appName}] Wersja: 0.0.{appVersion}, Autor: {appAuthor}");

            Console.ResetColor();

            Console.WriteLine("Jak masz na imię?");

            string inputUserName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"Powodzenia {inputUserName}, odgadnij liczbę ...");

            Console.ResetColor();        
        
        }

    }
}
