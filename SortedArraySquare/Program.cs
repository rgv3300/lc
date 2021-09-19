using System;

namespace SortedArraySquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -10, -4, 3, 5, 6 };

            Solution.SortedSquares(nums);
        }
        public class Solution
        {
            public static int[] SortedSquares(int[] nums)
            {
                for (int i = 0; i < nums.Length; i++)
                    nums[i] *= nums[i];
                for (int i = 0; i < nums.Length; i++)
                {
                    int min_idx = i;
                    for (int j = i + 1; j < nums.Length; j++)
                        if (nums[j] < nums[min_idx])
                            min_idx = j;
                    int temp = nums[min_idx];
                    nums[min_idx] = nums[i];
                    nums[i] = temp;
                }
                return nums;
            }
        }
    }
}
