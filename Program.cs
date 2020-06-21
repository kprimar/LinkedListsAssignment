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
        public static Node current;
        public static int listLength;
        public void append(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                listLength = 1;
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
                listLength++;

            }
            current.next = new Node(data);
        }

        public void DeleteByData(int data)
        {
            if (head == null) return;
            if (head.data == data)
            {
                head = head.next;
                listLength--;
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    listLength--;
                    return;
                }
                current = current.next;
            }
        }
        public void DeleteAtIndex(int index)
        {
            if (head == null) return;
            Node current = head;
            int currentNodeIndex = 0;
            if (currentNodeIndex == index)
            {
                head = head.next;
                listLength--;
                return;
            }
            for (currentNodeIndex = 1; currentNodeIndex < index; currentNodeIndex++)
            {
                current = current.next;
            }
            current.next = current.next.next;
            listLength--;
        }
        }
    }
