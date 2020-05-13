using System;
using System.Collections.Generic;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }

    public class LinkedList
    {
        public Node head;
        public int listLength;
        public void append(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }
            Node current = head;
            listLength = 1;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(data);
            listLength++;
        }

        public int GetListLength()
        {
            return listLength;
        }

        public void DeleteByData(int data)
        {
            if (head == null) return;
            if (head.data == data)
            {
                head = head.next;
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }
        public void DeleteAtIndex(int index)
        {
            Node current = head;
            int currentNodeIndex = 0;
            while (currentNodeIndex < index)
            {
                current = current.next;
                currentNodeIndex++;
            }
            current.next = current.next.next;
            current = current.next;
        }
    }




}
