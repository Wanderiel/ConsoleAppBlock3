using System;

namespace ConsoleAppB3P6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int maxRandom = 100;
            int size = 30;
            int[] numbers = new int[size];
            int shift = 1;

            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(maxRandom);
                Console.Write($"{numbers[i]} ");
            }

            for (int i = 0; i < size - shift; i++)
            {
                if (numbers[i] > numbers[i + shift])
                {
                    (numbers[i], numbers[i + shift]) =
                        (numbers[i + shift], numbers[i]);

                    for (int j = i; j > 0; j--)
                    {
                        if (numbers[j - shift] > numbers[j])
                            (numbers[j - shift], numbers[j]) = 
                                (numbers[j], numbers[j - shift]);
                    }
                }
            }

            Console.WriteLine("\n\nПосле сортировки...");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.ReadKey();
        }
    }
}