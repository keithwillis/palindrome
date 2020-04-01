using System;

namespace Palindrome
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 57;
            Console.WriteLine(string.Format("{0} becomes a Palindrome in {1} steps", number, CreatePalindrome(number)));
        }

        private static int CreatePalindrome(int number)
        {
            int iterationCount = 0;
            return CreatePalindrome(number, iterationCount);
        }

        private static int CreatePalindrome(int number, int iterationCount)
        {
            int i = int.Parse(ReverseString(number.ToString()));

            if(isPalindrome(number.ToString(), i.ToString()))
                return iterationCount;

            string sum = (number + i).ToString();
            String revSum = ReverseString(sum);;
            iterationCount++;

            if(!isPalindrome(sum,revSum))
            {
                iterationCount = CreatePalindrome(int.Parse(sum), iterationCount);
            }
            return iterationCount;
        }

        private static bool isPalindrome(string first, string second)
        {
            return first == second;

        }

        private static string ReverseString(string toReverse)
        {
            Char[] reverseMe = toReverse.ToCharArray();
            Array.Reverse(reverseMe);
            return string.Join(string.Empty, reverseMe);
        }

    }
}
