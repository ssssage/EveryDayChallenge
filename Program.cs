using System;
using System.Collections.Generic;

namespace TheChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode listNode = new ListNode(1);
            listNode.AddToEnd(1);
            listNode.AddToEnd(2);
            listNode.AddToEnd(2);
            listNode.AddToEnd(3);
            Console.WriteLine("Using AddToEnd()");
            listNode.PrintList();

            Console.WriteLine();
            listNode.DeleteDuplicates(listNode);
            Console.WriteLine("\nAfter DeleteDuplicates()");
            listNode.PrintList();

            Console.WriteLine();
            Console.WriteLine("\nAfter LinkedList.Print()");
            LinkedList linkedList = new LinkedList();
            linkedList.AddToEnd(1);
            linkedList.AddToEnd(2);
            linkedList.AddToEnd(2);
            linkedList.AddToEnd(3);
            linkedList.AddToFront(4);
            linkedList.Print();
            Console.WriteLine();

            Console.WriteLine("\nAfter LinkedList.AddToFront()");
            LinkedList linkedList1 = new LinkedList();
            linkedList1.AddToEnd(4);
            linkedList1.AddToFront(1);
            linkedList1.AddToFront(2);
            linkedList1.AddToFront(2);
            linkedList1.AddToFront(3);
            linkedList1.Print();
            Console.WriteLine();
           

        }


    }
   
    

}
   