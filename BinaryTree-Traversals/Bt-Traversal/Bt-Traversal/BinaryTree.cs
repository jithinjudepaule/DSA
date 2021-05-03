using System;

namespace Bt_Traversal
{
    
    class BinaryTree
    {
        public Node root;
        class Node
        {
            public int key;
            public Node left, right;
            public Node(int key)
            {
                this.key = key;
            }
        }

        static void Main(string[] args)
        {
            root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.left.right = new Node(7);

        }
    }
}
