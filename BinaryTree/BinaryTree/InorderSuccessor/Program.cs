using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InorderSuccessor
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
    class Program
    {
        static Node root;
        static int flag = 0;
        static void Main(string[] args)
        {
            root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);

            inorder(root, 5);
        }

        private static void inorder(Node root, int nodeToFindSuccesor)
        {
            if (root == null)
            {
                return;
            }

            inorder(root.left, nodeToFindSuccesor);
            if (root.key == nodeToFindSuccesor)
            {
                flag = 1;
            }
            else
            {
                if (flag == 1)
                {
                    Console.WriteLine(root.key +"is succesor");
                    return;
                }
            }
            inorder(root.right, nodeToFindSuccesor);
        }
    }
}
