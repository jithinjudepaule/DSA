using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOrderWithDirectionChange
{
    class Program
    {// A Binary Tree Node
        public class Node
        {
            public Node left;
            public int data;
            public Node right;
        }
        static Node newNode(int data)
        {
            Node temp = new Node();
            temp.data = data;
            temp.left = temp.right = null;
            return temp;
        }
        static void Main(string[] args)
        {
            // Let us create binary tree
            Node root = newNode(1);
            root.left = newNode(2);
            root.right = newNode(3);
            root.left.left = newNode(4);
            root.left.right = newNode(5);
            root.right.left = newNode(6);
            root.right.right = newNode(7);
            root.left.left.left = newNode(8);
            root.left.left.right = newNode(9);
            root.left.right.left = newNode(3);
            root.left.right.right = newNode(1);
            root.right.left.left = newNode(4);
            root.right.left.right = newNode(2);
            root.right.right.left = newNode(7);
            root.right.right.right = newNode(2);
            root.left.right.left.left = newNode(16);
            root.left.right.left.right = newNode(17);
            root.right.left.right.left = newNode(18);
            root.right.right.left.right = newNode(19);
            multiDirectionTraversal(root);
        }

        static void multiDirectionTraversal(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            Stack<Node> stack = new Stack<Node>();
            Node temp = null;
            queue.Enqueue(root);
            int count = 0;
            int sizeOfNode;
            bool isRightToLeft = false;
            while (queue.Count != 0)
            {
                count++;
                sizeOfNode = queue.Count();

                for (int i = 0; i < sizeOfNode; i++)
                {
                    temp = queue.Dequeue();

                    if (!isRightToLeft)
                    {
                        Console.Write(temp.data +" ");
                    }

                    else
                    {
                        stack.Push(temp);
                    }

                    if (temp.left != null)
                    {
                        queue.Enqueue(temp.left);
                    }

                    if (temp.right != null)
                    {
                        queue.Enqueue(temp.right);
                    }
                }

                if (isRightToLeft == true)
                {
                    while (stack.Count != 0)
                    {
                        temp = stack.Pop();
                        Console.Write(temp.data + " ");
                    }
                }

                if (count == 2)
                {
                    isRightToLeft = !isRightToLeft;
                    count = 0;
                }
                Console.Write("\n");
            }
        }
    }
}
