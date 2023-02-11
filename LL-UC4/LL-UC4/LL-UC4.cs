using System;
using System.Collections.Generic;

namespace LL_UC4
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
        public int Index(int data)
        {
            int count = -1;
            if (head == null)
                return -1;
            Node t = head;
            while (t != null)
            {
                count++;
                if (t.data.Equals(data))
                    return count;
                t = t.next;

            }
            return -1;
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
        public void Insert(int ind, int data)
        {
            Node n = new Node(data);
            if (ind == 0)
            {
                n.next = head;
                head = n;
            }
            Node t = head, pre = null;
            while (ind > 0 && t != null) 
            {
                ind--;
                pre = t;
                t = t.next;
            }
            if (ind == 0)
            {
                pre.next = n;
                n.next = t;
            }
            throw new NullReferenceException("index is not in range");
        }
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(56);
            myList.AddLast(70);
            myList.Insert(1, 30);
            foreach (int d in myList)
            {
                Console.WriteLine(d);
            }
        }
    }
}
