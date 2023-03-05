using System;

namespace ConsoleAppB3P7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            char separator = ' ';

            Console.Write("Введите предложение: ");
            userInput = Console.ReadLine();

            Console.WriteLine();

            foreach (string unit in userInput.Split(separator))
            { 
                Console.WriteLine(unit);
            }

            Console.ReadKey();
        }
    }
}