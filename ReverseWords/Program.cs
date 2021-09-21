using System;
using System.Collections.Generic;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Let's take LeetCode contest";
            Solution.ReverseWords(s);
        }

        public class Solution
        {
            public static string ReverseWords(string s)
            {
                List<string> arr = new List<string>(s.Split(" "));
                for (int i = 0; i < arr.Count; i++)
                {
                    char[] c = arr[i].ToCharArray();
                    Array.Reverse(c);
                    arr[i] = new string(c);
                }
                s = String.Join(" ", arr);
                Console.WriteLine(" " + s);
                return s;
            }
        }
    }
}

