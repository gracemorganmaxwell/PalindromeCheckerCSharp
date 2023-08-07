using System;

namespace PalindromeChecker
{
    public static class Checker
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to our Palindrome Checker in C#");
            Console.WriteLine("Please input a word to be checked:");

            string input = Console.ReadLine();

            // Removing case sensitivity for comparison
            string lowerCaseInput = input.ToLower();

            // Reversing the string
            string reversed = new string(lowerCaseInput.Reverse().ToArray());

            if (lowerCaseInput == reversed)
            {
                Console.WriteLine("Valid, yes that's a Palindrome.");
            }
            else
            {
                Console.WriteLine("Not Valid, a Palindrome is a word that is spelt the same forwards and backwards; please try again.");
            }
        }
    }
}
