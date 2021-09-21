using System;
using System.Linq;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            Solution.MoveZeroes(nums);
        }
        public class Solution
        {
            public static void MoveZeroes(int[] nums)
            {
                int j = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0) j++;
                }
                nums = nums.Where(value => value != 0).ToArray();
                int[] m = new int[j];
                for (int i = 0; i < m.Length; i++)
                    m[i] = 0;
                nums = nums.Concat(m).ToArray();
                for (int i = 0; i < nums.Length; i++)
                    Console.WriteLine("" + nums[i]);
            }
        }
    }
}
