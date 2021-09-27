using System;
using DisjointSet;

namespace NumberOfProvinces
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] isConnected = new int[][] { new int[] { 1, 1, 0 }, new int[] { 1, 1, 0 }, new int[] { 0, 0, 1 } };
            int provinceNumber = isConnected.Length;
            UnionFind connectedCities = new UnionFind(isConnected.Length);
            for (int i = 0; i < isConnected.Length; i++)
            {
                for (int j = 0; j < isConnected.Length; j++)
                {
                    if (isConnected[i][j] == 1)
                    {
                        connectedCities.QuickUnion(i, j);

                    }
                }
            }
            Console.WriteLine(" " + connectedCities.count);
        }
    }
}