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
            if(!int.TryParse(input, out number))
            {
                Console.WriteLine("The input was not in correct format.");
                return;
            }

            CheckEvenOrOdd(number);
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
    }
}
