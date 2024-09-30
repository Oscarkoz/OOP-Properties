namespace Methodsövning2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalChars = CountTotal("Hello World");
            Console.WriteLine($"Total amount of characters: {totalChars}");

            int totalInts = CountTotal(1, 2, 3, 4, 5);
            Console.WriteLine($"Total number of integers: {totalInts}");

            float totalFloats = CountTotal(1.1f, 2.2f, 3.3f, 4.4f);
            Console.WriteLine($"Total number of floats: {totalFloats}");
        }
        public static int CountTotal(params string[] strings)
        {
            if (strings.Length == 0)
            {
                Console.WriteLine("No strings entered");
                return 0;
            }
            int TotalCharCount = 0;

            foreach (string str in strings)
            {
                foreach (char c in str)
                {
                    if (c != ' ')
                    {
                        TotalCharCount++;
                    }
                }
            }
            return TotalCharCount;



        }
        public static int CountTotal(params int[] ints)
        {
            if (ints.Length == 0)
            {
                Console.WriteLine("No ints entered");
                return 0;
            }
            return ints.Length;
        }
        public static float CountTotal(params float[] floats)
        {
            if (floats.Length == 0)
            {
                Console.WriteLine("No Floats entered");
                return 0;
            }
            return floats.Length;
        }

    }
}
