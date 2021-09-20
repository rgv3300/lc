using System;
using System.Linq;
namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            int target = 20;
            Solution.Rotate(nums, target);
        }

        public class Solution
        {
            public static void Rotate(int[] nums, int k)
            {
                int p = k % nums.Length;
                int[] m = new int[p];
                int t = 0;
                for (int i = nums.Length - p; i < nums.Length; i++)
                {
                    m[t] = nums[i];
                    t++;
                }
                for (int j = 0; j < m.Length; j++)
                {
                    nums = nums.Where(val => val != m[j]).ToArray();
                }
                nums = m.Concat(nums).ToArray();
                for (int i = 0; i < nums.Length; i++)
                    Console.WriteLine("" + nums[i]);
            }
        }
    }
}
