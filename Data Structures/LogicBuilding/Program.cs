using System;

namespace LogicBuilding
{
    public struct IntPair
    {
        public int Number1 { get; set; }

        public int Number2 { get; set; }
    }

    public class IntegerPair
    {
        public int Number1 { get; set; }

        public int Number2 { get; set; }
    }

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
            SumofnNaturalNumbers(number);
            SumofSquaresofFirstnNaturalNumbers(number);

            int num2 = 12;
            SwapTwoNumbers(ref number, ref num2);

            IntegerPair p1 = new IntegerPair();
            p1.Number1 = number;
            p1.Number2 = 23;

            IntPair p2 = new IntPair
            {
                Number1 = number,
                Number2 = 34,
            };

            SwapTwoNumbers(p1);
            SwapTwoNumbers(ref p2);

            IntegerPair p3 = new IntegerPair();
            p3.Number1 = number;
            p3.Number2 = 4;

            FindClosesttonandDivisiblebym(p3);

            string ss = DecimaltoBinary.DectoBinConv(43);
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
        private static void SumofnNaturalNumbers(int number)
        {
            if (number < 1)
            {
                Console.WriteLine("Your number is not natural.");
            }
            else
            {
                int sum = number * (number + 1) / 2;
                Console.WriteLine(sum);
            }
        }

        private static void SumofSquaresofFirstnNaturalNumbers(int number)
        {
            if (number < 1)
            {
                Console.WriteLine("Your number is not natural.");
            }
            else
            {
                int sum = (number * (number + 1) * (2 * number + 1)) / 6;
                Console.WriteLine(sum);
            }
        }

        private static void SwapTwoNumbers(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

        private static void SwapTwoNumbers(IntegerPair pair)
        {
            int temp = pair.Number1;
            pair.Number1 = pair.Number2;
            pair.Number2 = temp;
        }

        private static void SwapTwoNumbers(ref IntPair pair)
        {
            int temp = pair.Number1;
            pair.Number1 = pair.Number2;
            pair.Number2 = temp;
        }

        private static IntPair SwapTwoNumbers(IntPair pair)
        {
            return new IntPair
            {
                Number1 = pair.Number2,
                Number2 = pair.Number1,
            };
        }

        private static void FindClosesttonandDivisiblebym(IntegerPair pair)
        {
            //throw new NotImplementedException();
        }
    }
}
