using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 1000000001;

            Solution.IsPalindromeMySol(test);

        }
        public class Solution
        {
            public static bool IsPalindromeMySol(int x)
            {
                string inputToString = Convert.ToString(x);
                for (int i = 0; i < inputToString.Length - 1; i++)
                {
                    for (int j = inputToString.Length - 1; j >= i; j--)
                    {
                        if (inputToString[j] != inputToString[i])
                        {
                            Console.WriteLine("False");
                            return false;
                        }
                        i++;
                    }
                    if (i > (inputToString.Length - 1) / 2) goto True;
                }
            True:
                Console.WriteLine("True");
                return true;
            }
            public static bool IsPalindromeOpt(int x)
            {
                string inputToString = Convert.ToString(x);

                int left = 0;
                int right = inputToString.Length - 1;

                while (left < right)
                {
                    if (inputToString[left] != inputToString[right])
                        return false;
                    left++;
                    right--;
                }
                return true;
            }
        }
    }
}
