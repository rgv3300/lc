using System;

namespace FirstBadVersion
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = 2126753390;
            Solution.FirstBadVersion(n);
        }
        public class VersionControl
        {
            public static bool IsBadVersion(int n)
            {
                if (n == 1702766719) { return true; }
                else { return false; }
            }
        }
        public class Solution : VersionControl
        {
            public static int FirstBadVersion(int n)
            {
                int left = 1;
                int right = n;
                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (IsBadVersion(mid))
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                return left;
            }
        }
    }
}
