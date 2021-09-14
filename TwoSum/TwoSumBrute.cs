using System;
using System.Collections.Generic;

namespace lc1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 55, 45, 38, 6, 68, 19, 43, 100, 83, 33, 23, 50, 31, 77, 51, 72, 40, 22, 84, 10, 70, 44, 60, 26, 61, 20, 34, 9, 67, 96, 45, 24, 3, 95, 11, 80, 78, 16, 97, 92, 47, 8, 87, 53, 89, 1, 28, 59, 66, 79, 15, 42, 71, 30, 82, 69, 21, 73, 46, 64, 62, 88, 85, 2, 74, 93, 35, 52, 7, 37, 90, 25, 14, 58, 76, 81, 91, 75, 41, 86, 13, 63, 56, 57, 5, 18, 49, 54, 98, 4, 94, 29, 32, 36, 99, 39, 27, 48, 17, 65 };
            int target = 100;
            Solution.TwoSum(nums, target);
        }
        public class Solution
        {
            public static List<int> TwoSum(List<int> nums, int target)
            {
                List<int> result = new List<int>();
                for (int i = 0; i < nums.Count; i++)
                {
                    for (int j = 1; j < nums.Count; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            result.Add(i);
                            result.Add(j);
                            Console.WriteLine(String.Join(";", result));
                            return result;
                        }
                    }

                }
                return result;
            }
        }
    }
}
