using System;
using System.Collections.Generic;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 2147483647;
            StringToInt.Solution(input);
        }

        public class StringToInt
        {
            public static int Solution(int input)
            {
                if (input > int.MaxValue || input < int.MinValue)
                {
                    return 0;
                }
                int rev = 0;
                try
                {
                    while (input != 0)
                    {
                        int rem = input % 10;
                        input /= 10;
                        rev = rev * 10 + rem;
                    }
                }
                catch (OverflowException)
                {
                    return 0;
                }
                Console.WriteLine("result: " + rev);

                return rev;
            }
        }
    }
}
