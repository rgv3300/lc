using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] j = { 34, 44, 55, 66, 77, 88, 99, 444, 555, 666, 777, 888 };
            int target = 34;
            Solution.Search(j, target);
        }
        public class Solution
        {
            public static int Search(int[] nums, int target)
            {
                int left = 0;
                int right = nums.Length;
                int pivot = (left + right) / 2;

                while ((nums[pivot] != target) && (pivot != right) && (pivot != left))
                {
                    if (nums[pivot] > target)
                    {
                        right = pivot;
                        pivot = (left + pivot) / 2;
                    }
                    else
                    {
                        left = pivot;
                        pivot = (right + pivot) / 2;
                    }

                }
                if (nums[pivot] == target)
                {
                    Console.WriteLine(" " + pivot);
                    return pivot;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
