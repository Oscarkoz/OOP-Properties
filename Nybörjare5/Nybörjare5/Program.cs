using System;

namespace Nybörjare5
{
    internal class Program
    {
        static void Main(string[] args)
        {
       // 5. Write and call a method that checks which of two numbers is larger.
            string result = LargerNumber(3, 4);
            Console.WriteLine($"The largest number is: {result}");
        }
        public static string LargerNumber(int number1, int number2)
        {
            if (number1 > number2)
            {
                return $"{number1}";
            }
            else if (number2 > number1)
            {
                return $"{number2}";
            }
            else
            {
                return "Both numbers are equal";
            }
        }
    }
}
