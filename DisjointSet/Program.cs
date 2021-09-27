using System;

namespace DisjointSet
{
    class Program
    {
        static void Main(string[] args)
        {
            UnionFind graph = new UnionFind(10);
            graph.Print();
            graph.Union(1,9);
            graph.Union(1,4);
            graph.Union(2,5);
            graph.Union(4,5);
            graph.Union(6,7);
            graph.Print();
        }
        public class UnionFind
        {
            int[] root;

            public UnionFind(int size)
            {
                root = new int[size];
                for(int i = 0; i < size;i++)
                {
                    root[i] = i;
                }
            }

            public int Find(int x)
            {
                return root[x];
            }

            public void Union(int x,int y)
            {
                int rootX = Find(x);
                int rootY = Find(y);
                if(rootX != rootY)
                {
                    for(int i = 0; i < root.Length; i++)
                    {
                        if(root[i] == rootY)
                            root[i] = rootX;
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
                    Console.WriteLine(" " + root[i]);
            }
        }
    }
}
