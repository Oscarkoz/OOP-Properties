using System;

namespace Intermediate2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. Write a program that calculates the sum of an array.
            int[] numbers = { 20, 40, 60, 80 };
            int result = SumofArray(numbers);
            Console.WriteLine($"The sum of the array is {result}");
        }
        public static int SumofArray(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            return sum;
        }
    }
}
