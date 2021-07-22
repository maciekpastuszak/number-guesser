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

            string info = $"[{appName}] Wersja: 0.0.{appVersion}, Autor: {appAuthor}";

            PrintColorMessage(ConsoleColor.Magenta, info);
            
        }

    

        static string GetUserName()
        {
            Console.WriteLine("Jak masz na imię?");

            string inputUserName = Console.ReadLine();

            return inputUserName;
        }

        static void GreetUser (string userName)
        {
            string greet = $"Powodzenia {userName}, odgadnij liczbę ...";

            PrintColorMessage(ConsoleColor.Blue, greet);

        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
