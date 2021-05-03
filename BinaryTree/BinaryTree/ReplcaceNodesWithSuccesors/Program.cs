using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Replace each node in binary tree with the sum of its inorder predecessor and successor
namespace ReplcaceNodesWithSuccesors
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
        static List<int> inorderArray= new List<int>();
        static List<int> transformedArray = new List<int>();
        static int i = 0;
        static void Main(string[] args)
        {
            root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);

            inorder(root);
            transformedArray=ReplaceNodes(inorderArray.ToArray()).ToList();
            inOrderReplacenodes(root);

        }

        private static void inOrderReplacenodes(Node root)
        {
            if (root == null)
            {
                return;
            }
            inOrderReplacenodes(root.left);
            root.key = transformedArray[i];
            i++;
            Console.WriteLine($"{root.key} ");
            inOrderReplacenodes(root.right);
        }

        private static int[] ReplaceNodes(int[] inorderArray)
        {
            int[] transformedArray = new int[inorderArray.Length];

            for (int i = 0; i < inorderArray.Length; i++)
            {
                if (i == 0)
                {
                    transformedArray[i] = inorderArray[i + 1];
                }

                else if (i==inorderArray.Length-1)
                {
                    transformedArray[i] = inorderArray[i - 1];
                }

                else
                {
                    transformedArray[i] = inorderArray[i + 1] + inorderArray[i - 1];
                }
            }


            return transformedArray;
        }

        private static void inorder(Node root)
        {
            if (root==null)
            {
                return;
            }
            inorder(root.left);
            inorderArray.Add(root.key);
            inorder(root.right);

        }
    }
}
