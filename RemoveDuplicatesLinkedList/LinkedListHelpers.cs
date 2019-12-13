using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesLinkedList
{
    public class LinkedListHelpers
    {
        public class Node
        {
            public String data;
            public Node next;
            public Node(String d)
            {
                data = d;
                next = null;
            }
        }
        public static Node removeDuplicates(Node head)
        {
            if (head != null)
            {
                Node start = head;
                while (start != null)
                {
                    if (start.next != null && start.data == start.next.data)
                    {
                        
                        start.next = start.next.next;
                      
                    }
                    else
                    {
                        start = start.next;
                    }
                }
            }

            return head;
        }

        public static Node Insert(Node head, String data)
        {
            Node p = new Node(data);
            if (head == null)
            {
                head = p;
            }
            else if (head.next == null)
            {
                head.next = p;
            }
            else
            {
                Node start = head;
                while (start.next != null)
                {
                    start = start.next;
                }
                start.next = p;
            }
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}



  
