using System;

namespace RemoveNthNode
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l10 = new LinkedList(1);
            LinkedList l9 = new LinkedList(3, l10);
            LinkedList l8 = new LinkedList(6, l9);
            LinkedList l7 = new LinkedList(8, l8);
            LinkedList l6 = new LinkedList(3, l7);
            LinkedList l5 = new LinkedList(7, l6);
            LinkedList l4 = new LinkedList(8, l5);
            LinkedList l3 = new LinkedList(3, l4);
            LinkedList l2 = new LinkedList(0, l3);
            LinkedList l1 = new LinkedList(9, l2);
            Solution.RemoveNthNode(l1, 10);
        }
        public class LinkedList
        {
            public int value;
            public LinkedList next;
            public LinkedList(int val = 0, LinkedList nxt = null)
            {
                value = val;
                next = nxt;
            }
        }
        public class Solution
        {
            public static LinkedList RemoveNthNode(LinkedList head, int n)
            {
                LinkedList listEnd = head;
                LinkedList temp = head;
                int listLength = 1;
                while (listEnd.next != null)
                {
                    listEnd = listEnd.next;
                    listLength++;
                }
                if (listLength == 1)
                {
                    head = null;
                }
                else if (listLength - n == 0)
                {
                    return head.next;
                }
                else
                {
                    for (int i = 1; i < listLength; i++)
                    {
                        if (i == listLength - n)
                        {

                            temp.next = temp.next.next;
                        }
                        else
                        {
                            temp = temp.next;
                        }
                    }
                }
                return head;
            }

        }
    }
}
