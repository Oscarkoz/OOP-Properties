namespace Intermediate2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of values you want to sum");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer");
            }

            string[] enteredNumbers = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter a number {i + 1}:");
                enteredNumbers[i] = Console.ReadLine();
            }

            int result = SumofArray(enteredNumbers);
            Console.WriteLine($"the sum of the entered numers is: {result}");
        }
        public static int SumofArray(string[] enteredNumbers)
        {
            int sum = 0;
            foreach (string number in enteredNumbers)
            {
                if (int.TryParse(number, out int num))
                {
                    sum += num;
                }
                else
                {
                    Console.WriteLine($"'{number}' is not a valid number and will be ignored");
                }
            }
            return sum;
        }
    }
}
