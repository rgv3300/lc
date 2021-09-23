using System;

namespace Heapify
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 2, 4, 5, 23, 532, 42 };
            int n = arr.Length;
            int i = (arr.Length / 2) - 1;
            for (int k = i; k >= 0; k--)
            {
                Heapify(arr, n, k);
            }
            for (int j = 0; j < arr.Length; j++)
                Console.WriteLine(" " + arr[j]);
        }
        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int l = i * 2 + 1;
            int r = i * 2 + 2;

            if (arr[l] > arr[r])
            {
                if (arr[l] > arr[i])
                {
                    int temp = arr[i];
                    arr[i] = arr[l];
                    arr[l] = temp;
                }
            }

            if (arr[r] > arr[l])
            {
                if (arr[r] > arr[i])
                {
                    int temp = arr[i];
                    arr[i] = arr[r];
                    arr[r] = temp;
                }
            }


        }
    }
}
