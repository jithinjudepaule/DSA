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

        PrintList();
    }

    private static void PrintList()
    {
        Node n = head;

        while (n!=null)
        {
            Console.WriteLine(n.data);
            n = n.next;
        }
    }
}
