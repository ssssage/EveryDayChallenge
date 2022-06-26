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

        }


    }
   
    

}
   