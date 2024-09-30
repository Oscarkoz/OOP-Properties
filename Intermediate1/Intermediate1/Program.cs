using System;

namespace Intermediate1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6. Write a program that checks if a word is a palindrome.
            Console.WriteLine("Please enter a word to see if its a palindrome or not");
            string input = Console.ReadLine();
            
            string result = Palindrome(input);
            Console.WriteLine(result);
        }
        public static string Palindrome(string word)
        {
            string normalizedWord = word.Replace(" ", "").ToLower(); 
            char[] charArray = normalizedWord.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);

            if (normalizedWord == reversedWord)
            {
                return "The word is a palindrome.";
            }
            else
            {
                return "The word is not a Palindrome";
            }
        }
    }
}
