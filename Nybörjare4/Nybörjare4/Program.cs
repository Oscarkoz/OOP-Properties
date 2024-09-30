namespace Nybörjare4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Write and call a method that checks if a number is even.
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            string result = EvenorUneven(number);
            Console.WriteLine($"The number {number} is {result}.");
        }
        public static string EvenorUneven(int number)
        {
            if ( number % 2 == 0)
            {
                return "Even";
            }
            else 
            {
                return "Uneven";
            }
        }
    }
}
