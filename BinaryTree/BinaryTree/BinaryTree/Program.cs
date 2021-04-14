using System;

namespace BinaryTree
{

    public class Node
    {
        int item;
        public Node left, right;

        public Node(int key)
        {
            item = key;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public Node root;
        public BinaryTree(int key)
        {
            root = new Node(key);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            Console.WriteLine("Hello World!");
        }
    }
}
