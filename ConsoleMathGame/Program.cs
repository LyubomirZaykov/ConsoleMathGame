using System;

namespace ConsoleMathGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your name:");
            string name = Console.ReadLine();
            DateTime date = DateTime.UtcNow;
            Menu(name, date);

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
                        AdditionGame("Addition game");
                        break;
                    case "s":
                        SubstractionGame("Substraction game");
                        break;
                    case "m":
                        MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        DivisionGame("Division game");
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
            void AdditionGame(string message)
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
                    int result = int.Parse(Console.ReadLine());

                    if (result == firstNumber + secondNumber)
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
                    if (i==4)
                    {
                        Console.WriteLine($"Game over.Your final score is {score}");
                    }
                }
                
            }
            void SubstractionGame(string message)
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
                    int result = int.Parse(Console.ReadLine());

                    if (result == firstNumber - secondNumber)
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
                        Console.WriteLine($"Game over.Your final score is {score}");
                    }
                }
            }


            void MultiplicationGame(string message)
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
                    int result = int.Parse(Console.ReadLine());

                    if (result == firstNumber * secondNumber)
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
                        Console.WriteLine($"Game over.Your final score is {score}");
                    }
                }
            }
            void DivisionGame(string message)
            {
                
                Random rand = new Random();
                
                int firstNumber;
                int secondNumber;
                int score = 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);
                    int[] numbers = GetDivisionNumbers();
                    firstNumber = numbers[0];
                    secondNumber = numbers[1];
                    Console.WriteLine($"{firstNumber} / {secondNumber}");
                    int result = int.Parse(Console.ReadLine());

                    if (result == firstNumber / secondNumber)
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
                        Console.WriteLine($"Game over.Your final score is {score}");
                    }
                }
            }
            int[] GetDivisionNumbers()
            {
                Random rand = new Random();
                int firstNumber = rand.Next(10, 100);
                int secondNumber = rand.Next(1, 10);
                while (firstNumber%secondNumber!=0||firstNumber/secondNumber>9)
                {
                    firstNumber = rand.Next(10, 100);
                    secondNumber = rand.Next(1, 10);
                }
                
                int[] result = new int[] { firstNumber, secondNumber };
                return result;
            }
        }
    }
}
