namespace LinkedList_UC1
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
        static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome to LinkedList Problem! *****");
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(56);
            myList.AddFirst(30);
            myList.AddFirst(70);
            foreach (int d in myList)
            {
                Console.WriteLine(d);
            }
        }
    }
}