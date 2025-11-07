using System;

namespace LogicBuilding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give me a number: ");
            string input = Console.ReadLine();

            int number = 0;
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("The input was not in correct format.");
                return;
            }

            CheckEvenOrOdd(number);
            Multiplication(number);
        }

        private static void CheckEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        private static void Multiplication(int number)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i:#0}*{number:#0}={i * number}");
            }
        }
    }
}
