using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace CSharpAlgorithms
{
    public class LinkedListAlgorithms
    {
        public class CustomLinkedList
        {
            public Node head;
            public class Node
            {
                public int data;
                public Node next;
                public Node(int d) { data = d; }
            }
            public void DeleteBackHalf()
            {
                if(head == null || head.next == null) {
                    head = null;
                }

                Node slow = head;
                Node fast = head;
                Node prev = null;

                while (fast != null && fast.next != null)
                {
                    prev = slow;
                    slow = slow.next;
                    fast = fast.next.next;                    
                }
                prev.next = null;
            }

            public void DeleteKthNodeFromEnd(int k)
            {
                if (head == null || k == 0) { return; }
                
                Node first = head;
                Node second = head;

                for(int i = 0; i < k; i++)
                {
                    second = second.next;
                    if (second.next == null)
                    {
                        if (i == k - 1)
                        {
                            head = head.next;
                        }
                        return;
                    }
                }
                while(second.next != null)
                {
                    first = first.next;
                    second = second.next;
                }
                first.next = first.next.next;
            }

            public void DisplayContents()
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.data + " -> ");
                    current = current.next;
                }
            }

            public bool HasCycle()
            {
                HashSet<Node> nodes = new HashSet<Node>();
                Node current = head;

                while (current != null)
                {
                    if (nodes.Contains(current))
                    {
                        return true;
                    } else
                    {
                        nodes.Add(current);
                    }
                    current = current.next;
                }
                return false;
            }
        }

        //static void Main(string[] args)
        //{
        //    CustomLinkedList linkedListWithoutCycle = new CustomLinkedList();
        //    CustomLinkedList.Node firstNode = new CustomLinkedList.Node(3);
        //    CustomLinkedList.Node secondNode = new CustomLinkedList.Node(4);
        //    CustomLinkedList.Node thirdNode = new CustomLinkedList.Node(5);
        //    CustomLinkedList.Node fourthNode = new CustomLinkedList.Node(6);
        //
        //    linkedListWithoutCycle.head = firstNode;
        //    firstNode.next = secondNode;
        //    secondNode.next = thirdNode;
        //    thirdNode.next = fourthNode;
        //
        //    Console.WriteLine(linkedListWithoutCycle.HasCycle());
        //
        //    CustomLinkedList cycledLinkedList = new CustomLinkedList();
        //    cycledLinkedList.head = firstNode;
        //    thirdNode.next = secondNode;
        //
        //    Console.WriteLine(cycledLinkedList.HasCycle());
        //}
        
    }
}
