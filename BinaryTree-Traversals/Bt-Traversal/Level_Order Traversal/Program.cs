using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_Order_Traversal
{
    class BinaryTree
    {
         static Node root;
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
            root.right.right = new Node(7);

            PrintLevelOrder(root);

        }

        static void PrintLevelOrder(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count!=0)
            {
                var temp = queue.Dequeue();
                Console.WriteLine(temp.key);
                if (temp.left!=null)
                {
                    queue.Enqueue(temp.left);
                }

                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
            }
        }
    }
}
