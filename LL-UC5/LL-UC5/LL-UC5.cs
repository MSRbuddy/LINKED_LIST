using System;
using System.Collections.Generic;

namespace LL_UC5
{
    internal class Program
    {
        internal class Node
        {
            internal int data;
            internal Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        internal Node head;
        internal void Add(int d)
        {
            Node n = new Node(d);
            if (head == null)
            {
                head = n;
            }
            n.next = head;
            head = n;
        }
        public bool RemoveFirst(int input)
        {
            if (head == null)
                return false;
            if (head.next == null)
                head = null;
            Node t = head, pre = null;
            while (t != null)
            {
                if (t.data == input)
                {
                    if (pre == null)
                    {
                        head = t.next;
                        return true;
                    }
                    pre.next = t.next;
                    return true;
                }
                pre = t;
                t = t.next;
            }
            return false;
        }
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(56);
            myList.AddLast(30);
            myList.AddLast(70);
            myList.RemoveFirst();
            foreach (int d in myList)
            {
                Console.WriteLine(d);
            }
        }
    }
}
