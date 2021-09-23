using System;

namespace Heapify
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 4, 6, 13, 10, 9, 8, 15, 17 };
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

            if (l < n && arr[l] > arr[i])
                largest = l;

            if (r < n && arr[r] > arr[l])
                largest = r;

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                Heapify(arr, n, largest);
            }


        }
    }
}
