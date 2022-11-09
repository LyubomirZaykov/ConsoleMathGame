using ConsoleMathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMathGame
{
    internal class Helpers
    {
        static List<Game> games=new List<Game>();
        internal static int[] GetDivisionNumbers()
        {
            Random rand = new Random();
            int firstNumber = rand.Next(10, 100);
            int secondNumber = rand.Next(1, 10);
            while (firstNumber % secondNumber != 0 || firstNumber / secondNumber > 9)
            {
                firstNumber = rand.Next(10, 100);
                secondNumber = rand.Next(1, 10);
            }

            int[] result = new int[] { firstNumber, secondNumber };
            return result;
        }
        internal static void AddGameToTheHistory(int score, GameType gameType)
        {
            games.Add(new Game
            {
               Date = DateTime.Now,
               Score = score,
               Type=gameType
            }) ; 
        }
        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("----------------------------");
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts");
            }
            Console.WriteLine("----------------------------\n");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal static string ValidateResult(string result)
        {
            while (String.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                result = Console.ReadLine();
            }
            return result;
        }
    }
}
