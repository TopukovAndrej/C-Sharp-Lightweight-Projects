using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert a string to check if it's a palindrome:\n");
            
            string? str = Console.ReadLine();
            Console.WriteLine("\n");

            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("String cannot be empty or contain only whitespaces.");
                Environment.Exit(-1);
            }
            else
            {
                if (CheckIfPalindrome(str))
                {
                    Console.WriteLine(String.Format("The string {0} is a palindrome!\n", str));
                }
                else
                {
                    Console.WriteLine(String.Format("The string {0} is not a palindrome!\n", str));
                }
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Checks if the given string is a palindrome.
        /// </summary>
        /// <param name="s">The string that needs to be checked.</param>
        /// <returns>true if the string is a palindrome, false otherwise.</returns>
        static bool CheckIfPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }
    }
}