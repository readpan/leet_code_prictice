using System;
using LeetCodeReadPan.Easy;

namespace LeetCodeReadPan
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            palindrome_number palindromeNumber = new palindrome_number();
            Console.WriteLine(palindromeNumber.IsPalindrome(-121));
            
            reverse_integer reverseInteger = new reverse_integer();
            Console.WriteLine(reverseInteger.Reverse(-121) == -121);
        }
    }
}