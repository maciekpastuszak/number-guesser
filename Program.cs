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

            Console.WriteLine($"[{appName}] Wersja: 0.0.{appVersion}, Autor: {appAuthor}");
        }
    }
}
