using System;
using PalindromeExercise;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to see if it is a palindrome: ");
            var word = new WordSmith();
            var input = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(word.IsAPalindrome(input)); 
        }
    }
}
