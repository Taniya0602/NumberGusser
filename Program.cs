using System;

namespace NumberGusser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
            while (true)
            {

                //int correctnumber = 7;
                Random random = new Random();
                int correctnumber = random.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctnumber)
                {
                    string inputs = Console.ReadLine();
                    if (!int.TryParse(inputs, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");
                        continue;
                    }
                    guess = Int32.Parse(inputs);
                    if (guess != correctnumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, Please try again");
                    }
                }
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");
                Console.WriteLine("Want to play again? [Y or N]");
                string answer=Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }
        static void GetAppInfo()
        {
            string appname = "Name guesser";
            string appversion = "1.0.0";
            string appauthor = "Taniya Aggarwal";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appname, appversion, appauthor);
            Console.ResetColor();
        }
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hi {0}, Let's play game...", input);
        }
        static void PrintColorMessage(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
