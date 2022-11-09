using ConsoleMathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Random rand = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = rand.Next(1, 100);
                secondNumber = rand.Next(1, 100);
                Console.WriteLine($"{firstNumber} + {secondNumber}");
                string result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
                int numResult = int.Parse(result);
                if (numResult == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer is correct. Type any key for the next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Helpers.AddGameToTheHistory(score, GameType.Addition);
                    Console.WriteLine($"Game over.Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

        }
        internal void SubstractionGame(string message)
        {

            Random rand = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = rand.Next(1, 100);
                secondNumber = rand.Next(1, firstNumber);
                Console.WriteLine($"{firstNumber} - {secondNumber}");
                string result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
                int numResult = int.Parse(result);
                if (numResult == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer is correct. Type any key for the next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Helpers.AddGameToTheHistory(score, GameType.Substraction);
                    Console.WriteLine($"Game over.Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine(); ;
                }
            }
        }
        internal void MultiplicationGame(string message)
        {

            Random rand = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = rand.Next(1, 9);
                secondNumber = rand.Next(1, 9);
                Console.WriteLine($"{firstNumber} * {secondNumber}");
                string result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
                int numResult = int.Parse(result);
                if (numResult == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer is correct. Type any key for the next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Helpers.AddGameToTheHistory(score, GameType.Multiplication);
                    Console.WriteLine($"Game over.Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
        }
        internal void DivisionGame(string message)
        {

            Random rand = new Random();

            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                int[] numbers = Helpers.GetDivisionNumbers();
                firstNumber = numbers[0];
                secondNumber = numbers[1];
                Console.WriteLine($"{firstNumber} / {secondNumber}");
                string result = Console.ReadLine();
                result = Helpers.ValidateResult(result);
                int numResult = int.Parse(result);
                if (numResult == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer is correct. Type any key for the next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Helpers.AddGameToTheHistory(score, GameType.Division);
                    Console.WriteLine($"Game over.Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
        }
    }
}
