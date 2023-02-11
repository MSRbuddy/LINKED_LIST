using System;
using System.Collections;
using System.Collections.Generic;

namespace LL_UC10
{
   internal class Program
   {
        public class LinkedList
        {
            Node head;
            class Node
            {
                public int data;
                public Node next;
                public Node(int d)
                {
                    data = d;
                    next = null;
                }
            }
            void sortedInsert(Node new_node)
            {
                Node current;
                if(head == null || head.data >= new_node.data)
                {
                    new_node.next = head;
                    head = new_node;
                }
                else
                {
                    current = head;
                    while (current.next != null && current.next.data < current.next.data)
                        current = current.next;
                    new_node.next = current.next;
                    current.next = new_node;
                }
            }
            Node newNode(int data)
            {
                Node n = new Node(data);
                return n;
            }
            void printList()
            {
                Node temp = head;
                while(temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
            public static void Main(String[] args)
            {
                LinkedList Llist = new LinkedList();
                Node new_node;

                new_node = Llist.newNode(56);
                Llist.sortedInsert(new_node);
                
                new_node = Llist.newNode(30);
                Llist.sortedInsert(new_node);
                
                new_node = Llist.newNode(40);
                Llist.sortedInsert(new_node);
                
                new_node = Llist.newNode(70);
                Llist.sortedInsert(new_node);

                Console.WriteLine("Create Linked List is: ");
                Llist.printList();

            }
        }
    }
}
