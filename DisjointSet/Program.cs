using System;

namespace DisjointSet
{
    class Program
    {
        static void Main(string[] args)
        {
            UnionFind graph = new UnionFind(10);
            graph.Print();
            graph.Union(0, 1);
            graph.Union(1, 2);
            graph.Union(1, 3);
            graph.Union(4, 5);
            graph.Union(4, 6);
            graph.Union(1, 5);
            graph.Union(8, 9);
            graph.Union(5, 9);
            graph.Print();
            graph.Reset();
            graph.QuickUnion(0, 1); //quick union will create a different graph based on the slow find method.
            graph.QuickUnion(1, 2);
            graph.QuickUnion(1, 3);
            graph.QuickUnion(4, 5);
            graph.QuickUnion(4, 6);
            graph.QuickUnion(1, 5);
            graph.QuickUnion(8, 9);
            graph.QuickUnion(5, 9);
            graph.Print();
        }
        public class UnionFind
        {
            int[] root;
            int[] rank;

            public UnionFind(int size)
            {
                root = new int[size];
                rank = new int[size];
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
                if (root[x] == x)
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
}
