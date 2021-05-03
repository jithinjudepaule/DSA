using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionBasics
{
    class Program
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
        static Node root;
        static void Main(string[] args)
        {
            root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            inorder(root);
        }

        private static void inorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            inorder(root.left);
            Console.Write($"{root.key} ");
            inorder(root.right);
        }


    }
}
