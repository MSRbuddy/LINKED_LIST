using System.Xml;
using System.Xml.Linq;

namespace LL_UC2
{
    internal class program
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
            myList.AddFirst(70);
            myList.AddLast(30);
            myList.AddLast(56);
            foreach (int d in myList)
            {
                Console.WriteLine(d);
            }
        }
    }
}