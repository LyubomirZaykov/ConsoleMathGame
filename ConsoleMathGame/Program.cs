using System;

namespace ConsoleMathGame
{
    class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("Please type your name:");
            string name = Console.ReadLine();
            DateTime date = DateTime.UtcNow;
            Menu(name, date);
        }
        void Menu(string name, DateTime date)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. This is your math's game. That's great that you're working on improving yourself\n");
            Console.WriteLine("\n");
            Console.WriteLine($@"What game would you like to play today? Choose from the options below:
            A - addition
            S - substraction
            M - multiplication
            D - division
            Q - quit the program");
            Console.WriteLine("----------------------------------------------------------------");
            string gameSelected = Console.ReadLine();
            switch (gameSelected.ToLower().Trim())
            {
                case "a":
                    AdditionGame("Addition game selected");
                    break;
                case "s":
                    SubstractionGame("Substraction game selected");
                    break;
                case "m":
                    MultiplicationGame("Multiplication game selected");
                    break;
                case "d":
                    DivisionGame("Division game selected");
                    break;
                case "q":
                    Console.WriteLine("Goodbye");
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Environment.Exit(1);
                    break;
            }
        }

        void SubstractionGame(string message)
        {
            Console.WriteLine(message);
        }

        void AdditionGame(string message)
        {
            Console.WriteLine(message);
        }
        void MultiplicationGame(string message)
        {
            Console.WriteLine(message);

        }
        void DivisionGame(string message)
        {
            Console.WriteLine(message);
        }
    }
}
