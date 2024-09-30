namespace Fibonnacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
        public static int Fibonacci(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
