using System;
using System.Collections.Generic;

namespace LL_UC7
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
        internal void Search(int d)
        {
            if (head == null)
                throw new NullReferenceException("empty List");
            Node t = head;
            while (t != null)
            {
                if (t.data.Equals(d))
                t = t.next;
            }
        }
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(70);
            myList.AddLast(30);
            myList.AddLast(56);
            myList.Search(30);
            foreach (int d in myList)
            {
                Console.WriteLine(d);
            }
        }
    }
}
