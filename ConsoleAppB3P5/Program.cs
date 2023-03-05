using System;

namespace ConsoleAppB3P5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minRandom = 1;
            int maxRandom = 5;
            int start = 1;
            int shift = 1;
            int count = start;
            int maxCount = int.MinValue;
            int size = 30;
            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandom, maxRandom);
                Console.Write($"{numbers[i]} ");
            }

            int number = numbers[0];
            string search = $"{number} ";

            for (int i = start; i < numbers.Length; i++)
            {
                if (numbers[i - shift] == numbers[i])
                {
                    count++;

                    if (count == maxCount)
                        search += $"{number} ";

                    if (count > maxCount)
                    {
                        search = $"{number} ";
                        maxCount = count;
                    }
                }
                else
                {
                    count = start;
                    number = numbers[i];
                }
            }

            Console.WriteLine($"\n\nЧисло {search}встречалось {maxCount} раз подряд.");

            Console.ReadKey();
        }
    }
}