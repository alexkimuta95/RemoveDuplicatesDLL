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
            Console.WriteLine("Insert the input");
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {

                // int data = Int32.Parse(Console.ReadLine());
                String data = Console.ReadLine();

                head = Insert(head, data);
            }

            head = removeDuplicates(head);
            display(head);
            Console.ReadKey();

        }
    }
}
