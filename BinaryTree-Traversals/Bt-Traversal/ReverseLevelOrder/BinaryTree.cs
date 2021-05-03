using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLevelOrder
{
    class BinaryTree
    {
        public class Node
        {
            public int data;
            internal Node left, right;
            public Node(int data)
            {
                this.data = data;
            }
        }
        public static Node root;
        static void Main(string[] args)
        {
            root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            PrintReverseOrder(root);
        }

        private static void PrintReverseOrder(Node root)
        {
            if (root==null)
            {
                return;
            }

            if (root.left==null && root.right==null)
            {
                return;
            }

            Queue<Node> nodeQueue = new Queue<Node>();
            Stack<int> nodeStack = new Stack<int>();
            nodeQueue.Enqueue(root);
           
            while (nodeQueue.Count>0)
            {
                nodeStack.Push(nodeQueue.Peek().data);
                Node tempNode = nodeQueue.Dequeue();
           


                if (tempNode.right!=null)

                {
                   
                    nodeQueue.Enqueue(tempNode.right);
                }

                if (tempNode.left != null)

                {
                  
                    nodeQueue.Enqueue(tempNode.left);
                }

            }

            while (nodeStack.Count>0)
            {
                Console.Write(nodeStack.Pop());
            }


        }
    }
    }
