using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheChallenge
{
    public class ListNode
    {
        public int data;
        public ListNode next;
        public ListNode(int data)
        {
            this.data = data;
            this.next = null;
        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new ListNode(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }

        public void PrintList()
        {
            Console.Write("|" + data + "|->");

            if (next != null)
            {
                next.PrintList();
            }
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current_Node = head;

            while (current_Node != null && current_Node.next != null)
            {
                if (current_Node.next.data == current_Node.data)
                {
                    current_Node.next = current_Node.next.next;
                }

                else
                {
                    current_Node = current_Node.next;
                }
            }

            return head;
        }

    }

   
    public class LinkedList
    {
         public ListNode head;

        public LinkedList()
        {
            head = null;
        }
        public void AddToEnd(int data)
        {
            if (head == null)
            {
                head = new ListNode(data);
            }

            else
            {
                head.AddToEnd(data);
            }
        }

        public void Print()
        {
            if (head != null)
            {
                head.PrintList();
            }
        }

    }
}