using System;
using System.Collections;
using System.Collections.Generic;

namespace LL_UC10
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
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(30);
            myList.AddLast(40);
            myList.AddLast(56);
            myList.AddLast(70);
            foreach (int d in myList)
            {
                Console.WriteLine(d);
            }
        }
    }
}
