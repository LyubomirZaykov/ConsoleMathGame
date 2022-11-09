using System;
using System.Collections.Generic;

namespace ConsoleMathGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your name:");
            string name = Console.ReadLine();
            List<string> games = new List<string>();
            DateTime date = DateTime.UtcNow;
            Menu menu = new Menu();
            menu.ShowMenu(name, date);            
        }

    }
}
