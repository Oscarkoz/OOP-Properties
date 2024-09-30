namespace Recursions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(7));
        }
        static int Factorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;
            return number * Factorial(number - 1);
        }
    }
}
