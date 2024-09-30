using System;

namespace GetNumberFromUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromUser();
            Console.WriteLine($"You entered {number}");
        }
        static int GetNumberFromUser()
        {
            int number;
            while (true)
            {
                Console.WriteLine("Enter a number from 1-10: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    if (number >= 1 && number <= 10)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Put in a number that is within the 1-10 vicinity");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input, try again with a proper number");
                }
            }
        }
    }
}
