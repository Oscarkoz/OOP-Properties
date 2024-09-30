namespace Intermediate3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Console.WriteLine("Original array:");
            PrintArray(numbers);

            BubbleSort(numbers);
            Console.WriteLine("Sorted array (Bubble Sort):");
            PrintArray(numbers);

            numbers = new int[] { 5, 3, 8, 1, 2, 7, 4, 6 };
            Array.Sort(numbers);
            Console.WriteLine("Sorted array (Array.Sort:");
            PrintArray(numbers);
        }
        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[i] == array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
