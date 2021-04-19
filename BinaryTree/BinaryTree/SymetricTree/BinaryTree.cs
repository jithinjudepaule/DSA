using System;

namespace SymetricTree
{
    class BinaryTree
    {
        static Node root;
        static void Main(string[] args)
        {
            root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(2);
            root.left.left = new Node(3);
            root.left.right = new Node(4);
            root.right.left = new Node(4);
            root.right.right = new Node(3);
            
                if (CheckIfSymmetric(root,root))
                {
                    Console.WriteLine("The tree is symmetric");
                }
                else
                {
                    Console.WriteLine("The tree is not symmetric");
                }
        }

        private static bool CheckIfSymmetric(Node leftNode, Node rightNode)
        {
            if (leftNode==null && rightNode==null)
            {
                return true;
            }

           

            if (leftNode != null && rightNode != null && leftNode.key==rightNode.key)
            {
                return (CheckIfSymmetric(leftNode.left, rightNode.right) && CheckIfSymmetric(leftNode.right, rightNode.left));
            }
            else
            {
                return false;
            }
        }
    }

     class Node
    {
        internal Node left, right;
        internal int key;
        public Node(int key)
        {
            this.key = key;
        }
    }
}
