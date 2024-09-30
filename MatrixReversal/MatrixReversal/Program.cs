using System;

namespace MatrixReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrix = CreateMatrix(10);
            Console.WriteLine("Original Matrix");
            PrintMatrix(matrix);

            ReverseMatrix(matrix);
            Console.WriteLine("\nReversed matrix:");
            PrintMatrix(matrix);
        }

        static int[] CreateMatrix(int size)
        {
            int[] matrix = new int[size];
            for (int i = 0; i < size; i++)
            {
                matrix[i] = i + 1;
            }
            return matrix;
        }

        static void ReverseMatrix(int[] matrix)
        {
            int left = 0;
            int right = matrix.Length - 1;

            while (left < right)
            {
                int temp = matrix[left];
                matrix[left] = matrix[right];
                matrix[right] = temp;

                left++;
                right--;
            }
        }

        static void PrintMatrix(int[] matrix)
        {
            foreach (int number in matrix)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
