using System;

namespace SearchInsertPos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 5, 6, 9, 66, 67 };
            int target = 65;
            Solution.SearchInsert(nums, target);
        }

        public class Solution
        {
            public static int SearchInsert(int[] nums, int target)
            {
                int left = 0;
                int right = nums.Length;
                while (left < right)
                {
                    int pivot = left + (right - left) / 2;
                    if (nums[pivot] == target) return pivot;
                    if (nums[pivot] < target)
                    {
                        left = pivot + 1;
                    }
                    else
                    {
                        right = pivot;
                    }
                }
                if (left == right)
                {
                    return left;
                }
                return left - 1;
            }
        }
    }
}
