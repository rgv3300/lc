﻿using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = { 'j','j','h', 'e', 'l', 'l', 'o' };
            Solution.ReverseString(s);
        }
        public class Solution
        {
            public static void ReverseString(char[] s)
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    char temp = s[i];
                    s[i] = s[s.Length - i - 1];
                    s[s.Length - i - 1] = temp;
                }
            }
        }
    }
}
