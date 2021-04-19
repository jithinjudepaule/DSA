using System;
using System.Collections.Generic;

public class BinaryTree
{
    public static Node root;
    static void Main()
    {
        root = new Node(10);
        root.left = new Node(11);
        root.left.left = new Node(7);
        root.right = new Node(9);
        root.right.left = new Node(15);
        root.right.right = new Node(8);

        Console.Write("Inorder traversal before insertion:");
        traversTree(root);
        insert(root, 12);
        Console.WriteLine("Inorder traversal after insertion:");
        traversTree(root);
    }

    private static void traversTree(Node tempNode)
    {
        if (tempNode==null)
        {
            return;
        }

        traversTree(tempNode.left);
        Console.Write($"{tempNode.key} ");
        traversTree(tempNode.right);
    }

    private static void insert(Node temp, int key)
    {
        Queue<Node> nodeQueue = new Queue<Node>();
        nodeQueue.Enqueue(temp);
       

        while (nodeQueue!=null)
        {
            temp = nodeQueue.Peek();
           nodeQueue.Dequeue();
            if (temp.left == null)
            {
                temp.left = new Node(12);
                break;
            }
            else
            {
                nodeQueue.Enqueue(temp.left);
            }

            if (temp.right == null)
            {
                temp.right = new Node(12);
                break;
            }
            else
            {
                nodeQueue.Enqueue(temp.right);
            }

        }
       
    }

    public class Node
    {
      public  int key;
       public  Node left, right;
        
        public Node(int key)
        {
            this.key = key;
          
        }

      
    }
}