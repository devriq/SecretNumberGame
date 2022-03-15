using System;

namespace SecretNumberGame
{
    class Program
    {

        const string HEADER = "SECRET #Number Game!! Make your guess!!. by Arthur Cordovil";
        const string instructionColor = "Yellow";
        const string errorColor = "Red";
        const string successColor = "Green";
        const string primaryColor = "DarkMagenta";
        static int gameSecret = 8;
        static string input;
        static int userGuess;

        static void Main(string[] args)
        {
            printMessage(HEADER, primaryColor);
            printMessage("What's your name?", instructionColor);
            string inputName = Console.ReadLine();
            printMessage("Nice to meet you, "+inputName+" ! Let's play a game...",instructionColor);
            printMessage("Guess a number from 0 to 10, till you find the SECRET NUMBER!!!", instructionColor);
            printMessage("Make your guess...", instructionColor);
            input = Console.ReadLine();
            userGuess = Int32.Parse(input);
            checkResult(userGuess);
        }

        static void checkResult(int number)
        {
            while (number != gameSecret)
            {
                printMessage("ERROR", errorColor);
                printMessage("Make another guess...", instructionColor);
                input = Console.ReadLine();
                userGuess = Int32.Parse(input);
                checkResult(userGuess);
            }

            printMessage("SUCCESS", successColor);
            printMessage("GAME OVER", primaryColor);
            
            
        }

        static void printMessage(string message, string type)
        {
            switch (type)
            {
                case "DarkMagenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "Yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

            }
               
          Console.WriteLine(message);
          Console.ResetColor();
        }
    }
}
