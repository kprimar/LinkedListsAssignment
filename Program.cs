using System;
using System.Collections.Generic;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TESTING
            LinkedList myList = new LinkedList();
            myList.append(0);
            myList.append(6);
            myList.append(2);
            myList.append(3);
            Console.WriteLine(myList.listLength); 
            myList.DeleteAtIndex(1);
            Console.WriteLine(myList.listLength); 
            myList.DeleteByData(3);
            Console.WriteLine(myList.listLength);
            myList.DeleteByData(7);
            Console.WriteLine(myList.listLength);

            myList.append(7);
            Console.WriteLine(myList.listLength);
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
            Node current = head;
            int currentNodeIndex = 0;
            if (currentNodeIndex == index)
            {
                head = head.next;
                listLength--;
                return;
            }
            while (currentNodeIndex < index)
            {
                currentNodeIndex++;
                current = current.next;
                if (currentNodeIndex == index)
                {
                    current.next = current.next.next;
                    listLength--;
                }
                current = current.next;
            }
        }
    }




}
