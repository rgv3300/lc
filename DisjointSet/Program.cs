using System;

namespace DisjointSet
{
    public class UnionFind
    {
        private int[] root;
        private int[] rank;
        public int count;
        public UnionFind(int size)
        {
            root = new int[size];
            rank = new int[size];
            count = size;
            Reset();
        }

        public void Reset()
        {
            for (int i = 0; i < root.Length; i++)
            {
                root[i] = i;
                rank[i] = 1;
            }
        }

        public int QuickFind(int x)
        {
            return root[x];
        }

        public void Union(int x, int y)
        {
            int rootX = QuickFind(x);
            int rootY = QuickFind(y);
            if (rootX != rootY)
            {
                for (int i = 0; i < root.Length; i++)
                {
                    if (root[i] == rootY)
                        root[i] = rootX;
                }
            }
        }

        public int Find(int x)
        {
            if (x == root[x])
                return x;
            return x = Find(root[x]);
        }

        public void QuickUnion(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
            {
                if (rank[rootX] > rank[rootY])

                {

                    root[rootY] = rootX;

                }

                else if (rank[rootX] < rank[rootY])

                {

                    root[rootX] = rootY;

                }
                else

                {

                    root[rootY] = rootX;
                    rank[rootX]++;
                }
                count--;
            }

        }

        public bool Connected(int x, int y)
        {
            return Find(x) == Find(y);
        }

        public void Print()
        {
            for (int i = 0; i < root.Length; i++)
            {
                Console.WriteLine("{0} {1}", root[i], rank[i]);

            }
        }
    }
}