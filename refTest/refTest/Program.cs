using System;

namespace refTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 5;
            IncrementNumber(myNumber);
            // Output: 5 eller 6?
            Console.WriteLine($"IncrementNumber(): {myNumber}");

            IncrementNumberRef(ref myNumber);
            // Output: 5 eller 6?
            Console.WriteLine($"IncrementNumberRef(): {myNumber}");
        }

        // Value paramter (default)
        public static void IncrementNumber(int number)
        {
            number++;
        }

        // Reference paramter
        public static void IncrementNumberRef(ref int number)
        {
            number++;
        }
    }
}