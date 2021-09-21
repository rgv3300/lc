using System;

namespace TwoSumSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 4, 9, 56, 90 };
            int target = 8;
            Solution.TwoSum(numbers, target);
        }
        public class Solution
        {
            public static int[] TwoSum(int[] numbers, int target)
            {
                int[] result = new int[2];

                for (int i = 0; i < numbers.Length; i++)
                {
                    int l = i;
                    int r = numbers.Length - 1;
                    int complement = target - numbers[i];
                    while (r >= l)
                    {
                        int pivot = l + (r - l) / 2;


                        if (numbers[pivot] == complement)
                        {
                            result[0] = i;
                            result[1] = pivot;
                            return result;
                        }
                        else if (numbers[pivot] < complement)
                        {
                            l = pivot + 1;
                        }
                        else
                        {
                            r = pivot - 1;
                        }

                    }
                }
                return result;
            }
        }
    }
}
