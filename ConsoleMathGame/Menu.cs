using System;
namespace ConsoleMathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new GameEngine();
        internal void ShowMenu(string name, DateTime date)
        {

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. This is your math's game. That's great that you're working on improving yourself\n");
            Console.WriteLine("Please press any key to start the game");
            Console.WriteLine("\n");
            Console.ReadLine();
            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
                        V - View previous games
                        A - Addition
                        S - Substraction
                        M - Multiplication
                        D - Division
                        Q - Quit the program");
                Console.WriteLine("----------------------------------------------------------------");
                string gameSelected = Console.ReadLine();
                switch (gameSelected.ToLower().Trim())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubstractionGame("Substraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Press any key to go back to the main menu.");
                        Console.ReadLine();
                        break;
                }
            }
            while (isGameOn);

        }
    }
}
