using System;

namespace PostOrderfromInorder
{

    //    Input:
    //Inorder traversal in[] = {4, 2, 5, 1, 3, 6}
    //Preorder traversal pre[] = {1, 2, 4, 5, 3, 6}

    //Output:
    //Postorder traversal is {4, 5, 2, 6, 3, 1}

    //Inorder tree

    //            1
    //           / \
    //           2  3
    //           /\  \
    //          4  5  6
    class Program
    {
        static Node root;
        static void Main(string[] args)
        {
            root = new Node(1);
            root.left = new Node(2);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right = new Node(3);
            root.right.right = new Node(6);

            PostOrder(root);
        }

        private static void PostOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write($"{root.key} ");
        }
    }

    internal class Node
    {
        internal int key;
        internal Node left, right;

        public Node(int key)
        {
            this.key = key;
        }
    }
}
