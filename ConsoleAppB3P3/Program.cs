using System;

namespace ConsoleAppB3P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minRandom = 1;
            int maxRandom = 10;
            int shift = 1;
            int lenght = 30;
            int[] numbers = new int[lenght];

            ConsoleColor colorRed = ConsoleColor.Red;

            for (int i = 0; i < lenght; i++)
                numbers[i] = random.Next(minRandom, maxRandom);

            if (numbers[0] > numbers[shift])
                Console.ForegroundColor = colorRed;

            Console.Write($"{numbers[0]} ");

            Console.ResetColor();

            for (int i = 1; i < lenght - shift; i++)
            {
                if (numbers[i - shift] < numbers[i] && numbers[i] > numbers[i + shift])
                    Console.ForegroundColor = colorRed;

                Console.Write($"{numbers[i]} ");

                Console.ResetColor();
            }

            if (numbers[lenght - shift] > numbers[lenght - shift - shift])
                Console.ForegroundColor = colorRed;

            Console.Write($"{numbers[lenght - shift]} ");
            Console.Write("\n\nВсе локальные максимумы отмечены ");

            Console.ForegroundColor = colorRed;

            Console.WriteLine("цветом");

            Console.ReadKey();
        }
    }
}