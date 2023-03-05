using System;

namespace ConsoleAppB3P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Length = 3;

            Random random = new Random();

            int minRandom = 1;
            int maxRandom = 10;
            int maxNumber = int.MinValue;
            int substitute = 0;
            int rows = 10;
            int columns = 10;

            ConsoleColor colorRed = ConsoleColor.Red;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(minRandom, maxRandom);

                    if (maxNumber < matrix[i, j])
                        maxNumber = matrix[i, j];
                }
            }

            Console.WriteLine($"Дан двумерный массив {rows} на {columns}: \n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == maxNumber)
                        Console.ForegroundColor = colorRed;

                    Console.Write($"{matrix[i, j],Length}");
                    Console.ResetColor();
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\n\nМы заменили максимальное значение {maxNumber}" +
                $" на {substitute}:\n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == maxNumber)
                    {
                        matrix[i, j] = substitute;

                        Console.ForegroundColor = colorRed;
                    }

                    Console.Write($"{matrix[i, j],Length}");
                    Console.ResetColor();
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}