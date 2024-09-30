using System;

namespace PowerCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int baseNumber = 2;
            int exponent = 3;


            int result = CalculatePower(baseNumber, exponent);

            Console.WriteLine($"{baseNumber} raised to the power of {exponent} is: {result}");
        }


        public static int CalculatePower(int baseNumber, int exponent)
        {
            int result = 1; 

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            return result; 
        }
    }
}
