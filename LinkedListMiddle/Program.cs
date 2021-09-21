using System;

namespace LinkedListMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l5 = new LinkedList(5);
            LinkedList l4 = new LinkedList(4, l5);
            LinkedList l3 = new LinkedList(3, l4);
            LinkedList l2 = new LinkedList(2, l3);

            LinkedList l1 = new LinkedList(1, l2);
            Solution.LinkedListMiddle(l1);

        }
        public class LinkedList
        {
            public int value;
            public LinkedList next;
            public LinkedList(int Value = 0, LinkedList Next = null)
            {
                value = Value;
                next = Next;
            }

        }
        public class Solution
        {
            public static LinkedList LinkedListMiddle(LinkedList head)
            {
                LinkedList fast = head;
                while (fast != null && fast.next != null)
                {
                    head = head.next;
                    fast = fast.next.next;
                }
                Console.WriteLine(" " + head.value);
                return head;
            }
        }
    }
}
