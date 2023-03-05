using System;

namespace ConsoleAppB3P8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 9;
            int[] numbers = new int[size];

            string usetInput;

            Console.WriteLine("Дан массив чисел:\n");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
                Console.Write($"{numbers[i]} ");
            }

            Console.Write("\n\nНа слоклько позиций влево вы хотите его сдвинуть: ");
            usetInput = Console.ReadLine();

            if (int.TryParse(usetInput, out int shift))
            {
                if (Math.Abs(shift) >= numbers.Length)
                {
                    shift %= numbers.Length;
                    Console.WriteLine("\nСмещение больше размера массива." +
                        $"\nНовое смещение: {shift}");
                }

                if (shift < 0)
                {
                    shift = numbers.Length + shift;
                    Console.WriteLine("\nОтрицательное смещение это как смещение вправо." +
                        $"\nАналогичное смещение влево: {shift}");
                }

                Console.WriteLine();

                for (int i = 0; i < shift; i++)
                {
                    for (int j = 1; j < numbers.Length; j++)
                        (numbers[j], numbers[j - 1]) =
                            (numbers[j - 1], numbers[j]);
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nОжидалось число, смещение не выполнено.");
            }

            Console.ReadKey();
        }
    }
}