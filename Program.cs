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

            Random random = new Random();
            
            int correctNumber = random.Next(1,11);

            bool correctAnswer = false;

            Console.WriteLine("Zgadnij wylosowaną liczbę od 1 do 10");

            while(!correctAnswer)
            {
                string input = Console.ReadLine();

                int guess;

               bool isNumber =  int.TryParse(input, out guess);

                if (!isNumber)
                {
                    PrintColorMessage(ConsoleColor.Yellow, "Proszę wprowadzić liczbę.");
                    continue;
                }

                if(guess < 1 || guess > 10)
                {
                    PrintColorMessage(ConsoleColor.Yellow, "Proszę wprowadzić liczbę od 1 do 10.");
                    continue;
                }

                if(guess < correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Błędna odpowiedż. Wylosowana liczba jest większa.");
                }
                else if (guess > correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Błędna odpowiedż. Wylosowana liczba jest mniejsza.");
                }
                else
                {
                    correctAnswer = true;
                    PrintColorMessage(ConsoleColor.Green, "Brawo! Prawidłowa odpowiedźesen.");
                }
            }
         
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
