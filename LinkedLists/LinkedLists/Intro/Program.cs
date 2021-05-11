using System;

public class LinkedList
{
    public class Node
    {
        public Node next;
        public int data;
        public Node(int data)
        {
            this.data = data;
        }
    }

    static Node head;

    static void Main(string[] args)
    {
        head = new Node(1);
        Node second = new Node(2);
        Node third = new Node(3);
        head.next = second;
        second.next = third;

        PrintLinkedList();
        // InsertNodeAtHead();
       // InsertNodeAfterANode(second, 4);
        InsertNodeAtEnd(4);
        Console.WriteLine("After Insertion");
        PrintLinkedList();
    }

    private static void InsertNodeAtEnd(int nodeData)
    {
        Node newNode = new Node(nodeData);
        Node n = head;
        while (n.next!=null)
        {
            n = n.next;
        }

        n.next = newNode;
       
    }

    private static void PrintLinkedList()
    {
        Node n = head;

        while (n!=null)
        {
            Console.Write(n.data+" ");
            n = n.next;
        }
    }

    private static void InsertNodeAtHead()
    {
        Node newNode = new Node(4);
        newNode.next = head;

        head = newNode;
    }

    private static void InsertNodeAfterANode(Node prevNode, int nodeDataToInsert)
    {
        if (prevNode==null)
        {
            return;
        }

        Node newNode = new Node(nodeDataToInsert);
        newNode.next = prevNode.next;
        prevNode.next = newNode;
    }
}
