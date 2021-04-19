using System;

namespace FoldableBinaryTree
{

    public class Node
    {
        public int key;
        public Node left, right;
        public Node(int key)
        {
            this.key = key;
        }
    }
    class BinaryTree
    {
        public static Node root;
        static void Main(string[] args)
        {
            root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.right.left = new Node(4);
            root.left.right = new Node(5);
            //root.right.right = new Node(14);
            //root.left.left = new Node(15);
            //root.left.left.left = new Node(20);
            //root.left.left.right = new Node(20);
            //root.left.right.right = new Node(12);
            //root.left.right.left = new Node(12);
            //root.right.left.left = new Node(12);
            //root.right.left.right = new Node(30);
            //root.right.right.left = new Node(11);
            //root.right.right.right = new Node(11);

            if (CheckIfMirror(root))
            {
                Console.WriteLine("Tree is foldable");
            }

            else
            {
                Console.WriteLine("Tree is not foldable");
            }
        }

        private static bool CheckIfMirror(Node root)
        {
            if (root==null)
            {
                return true;
            }

            return CheckIfMirrorUtil(root.left, root.right);
        }

        private static bool CheckIfMirrorUtil(Node left, Node right)
        {
            if (left==null && right == null)
            {
                return true;
            }

            if (left == null || right == null)
            {
                return false;
            }

            return CheckIfMirrorUtil(left.left, right.right) && CheckIfMirrorUtil(left.right, right.left);
        }
    }
}
