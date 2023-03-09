using System;

namespace ConsoleAppB3P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ExitCommand = "exit";
            const string SumCommand = "sum";

            string userInput;

            int shift = 1;
            int[] numbers = Array.Empty<int>();

            bool isWork = true;

            Console.WriteLine($"Вводите любые числа, для подсчёта суммы " +
                $"введите - {SumCommand}, для выхода - {ExitCommand}.");

            while (isWork)
            {
                Console.Write("Введите число: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case ExitCommand:
                        Console.WriteLine("\nВсего доброго!");

                        isWork = false;
                        break;

                    case SumCommand:
                        int sum = 0;

                        foreach (int value in numbers)
                            sum += value;

                        Console.WriteLine($"\nСумма всех введённых чисел: {sum}");
                        break;

                    default:
                        if (int.TryParse(userInput, out int number))
                        {
                            int[] newNumbres = new int[numbers.Length + shift];

                            for (int i = 0; i < numbers.Length; i++)
                                newNumbres[i] = numbers[i];

                            numbers = newNumbres;
                            numbers[^shift] = number;
                        }
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}