using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveDuplicatesLinkedList;
using static RemoveDuplicatesLinkedList.LinkedListHelpers;

namespace LinkedListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = null;
            Console.WriteLine("How many nodes?");
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {

                // int data = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Type the node.....");
                String data = Console.ReadLine();

                head = Insert(head, data);
            }

            head = removeDuplicates(head);
            Console.WriteLine("The new linked list after removal of duplicates is....");
            display(head);
            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
