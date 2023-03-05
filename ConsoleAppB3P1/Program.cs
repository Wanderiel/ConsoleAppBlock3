using System;

namespace ConsoleAppB3P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Length = 3;

            Random random = new Random();

            int minRandom = 3;
            int maxRandom = 6;
            int sumRow = 0;
            int compositionColumn = 1;
            int row = 2;
            int column = 1;
            int shift = 1;

            int[,] matrix = new int[random.Next(minRandom, maxRandom), random.Next(minRandom, maxRandom)];

            Console.WriteLine("Дан двумерный массив: \n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(minRandom, maxRandom);

                    Console.Write($"{matrix[i, j],Length}");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
                sumRow += matrix[row - shift, i];

            for (int j = 0; j < matrix.GetLength(0); j++)
                compositionColumn *= matrix[j, column - shift];

            Console.WriteLine($"\nСумма чсех чисел в строке {row}: {sumRow}\n" +
                $"Произведение всех чисел в колонке {column}: {compositionColumn}");

            Console.ReadKey();
        }
    }
}