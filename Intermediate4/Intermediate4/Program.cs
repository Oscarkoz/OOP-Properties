using System;

namespace AverageArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define an array of integers
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Calculate the average
            double average = CalculateAverage(numbers);

            // Print the average
            Console.WriteLine($"The average of the array is: {average}");
        }

        // Method to calculate the average of an array
        public static double CalculateAverage(int[] array)
        {
            // Check if the array is empty
            if (array.Length == 0)
            {
                Console.WriteLine("The array is empty, cannot calculate the average.");
                return 0; // Return 0 or handle as needed
            }

            // Calculate the sum
            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }

            // Calculate the average
            double average = (double)sum / array.Length; // Cast sum to double for accurate division
            return average;
        }
    }
}
