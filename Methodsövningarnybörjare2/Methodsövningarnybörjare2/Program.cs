namespace Methodsövningarnybörjare2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write and call a method that returns the sum of two integer parameters.
            int result = CalculateSum(10, 20);
            Console.WriteLine($"The sum of the numbers are: {result}");
        }
        public static int CalculateSum(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
    }
}
