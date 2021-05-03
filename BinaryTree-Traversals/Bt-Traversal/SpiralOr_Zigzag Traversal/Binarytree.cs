using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralOr_Zigzag_Traversal
{
    class Binarytree
    {
        static Node root;
        public class Node
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
            root.left.left = new Node(7);
            root.left.left.right = new Node(8);
            root.left.right = new Node(6);
            root.left.right.left = new Node(9);
            root.right.left = new Node(5);
            root.right.right = new Node(4);
            printSpiral(root);
        }

        static void printSpiral(Node root)
        {
            Queue<Node> qNode = new Queue<Node>();
            Stack<int> stackNode = new Stack<int>();
            qNode.Enqueue(root);
            bool isRightToLeft = false;
            int count = 0;
             int size = 0;

            while (qNode.Count!=0)
            {
                size++;
                count = qNode.Count;
                for (int i = 0; i < count; i++)
                {
                    Node temp = qNode.Dequeue();
                    if (isRightToLeft)
                    {
                        stackNode.Push(temp.key);
                        if (temp.left != null)
                        {
                            qNode.Enqueue(temp.left);
                        }

                        if (temp.right != null)
                        {
                            qNode.Enqueue(temp.right);
                        }
                    }

                    else
                    {
                        Console.WriteLine(temp.key);
                        if (temp.left != null)
                        {
                            qNode.Enqueue(temp.left);
                        }

                        if (temp.right != null)
                        {
                            qNode.Enqueue(temp.right);
                        }
                    }

                }
                if (isRightToLeft)
                {
                    while (stackNode.Count != 0)
                    {
                        Console.WriteLine(stackNode.Pop());
                    }
                    isRightToLeft = !isRightToLeft;
                }

                if (size%2==0)
                {
                    isRightToLeft = !isRightToLeft;
                }

                
               
            }
        }
    }
}
