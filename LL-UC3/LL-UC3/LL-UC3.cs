using System.Xml.Linq;

namespace LL_UC3
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
        internal void Append(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
            }

            Node t = head;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = n;
        }
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.Append(56);
            myList.Append(30);
            myList.Append(70);
            foreach (int d in myList)
            {
                Console.WriteLine(d);
            }
        }
    }
}