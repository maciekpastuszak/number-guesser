using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            string userName = GetUserName();

            GreetUser(userName);       
         
        }

        static void GetAppInfo()
        {
            string appName = "Zgadywanie liczby";
            int appVersion = 1;
            string appAuthor = "Maciej Pastuszak";

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"[{appName}] Wersja: 0.0.{appVersion}, Autor: {appAuthor}");

            Console.ResetColor();
        }
        static string GetUserName()
        {
            Console.WriteLine("Jak masz na imię?");

            string inputUserName = Console.ReadLine();

            return inputUserName;
        }

        static void GreetUser (string userName)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"Powodzenia {userName}, odgadnij liczbę ...");

            Console.ResetColor();
        }
    }
}
