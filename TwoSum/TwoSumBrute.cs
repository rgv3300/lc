using System;
using System.Collections.Generic;

namespace lc1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 3, 3 };
            int target = 6;
            BruteForce.Solution(nums, target);
            HashMap.Solution(nums, target);
        }
        public class BruteForce
        {
            public static List<int> Solution(List<int> nums, int target)
            {
                List<int> result = new List<int>();
                for (int i = 0; i < nums.Count; i++)
                {
                    for (int j = 1; j < nums.Count; j++)
                    {
                        if (nums[j] == target - nums[i])
                        {
                            result.Add(i);
                            result.Add(j);
                            Console.WriteLine(String.Join(",", result));
                            return result;
                        }
                    }

                }
                return result;
            }
        }
        public class HashMap
        {
            public static List<int> Solution(List<int> nums, int target)
            {
                List<int> result = new List<int>();
                Dictionary<int, int> dictHash = new Dictionary<int, int>();
                for (int i = 0; i < nums.Count; i++)
                {
                    int complement = target - nums[i];
                    dictHash.Add(nums[i], i);
                    if (dictHash.ContainsKey(complement) && complement != nums[i])
                    {
                        result.Add(dictHash[nums[i]]);
                        result.Add(dictHash[complement]);
                        Console.WriteLine(String.Join(",", result));
                        return result;
                    }
                }
                return result;
            }
        }
    }
}
