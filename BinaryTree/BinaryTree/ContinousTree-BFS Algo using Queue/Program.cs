using System;
using System.Collections.Generic;

namespace ContinousTree_BFS_Algo_using_Queue
{

    public class Node
    {
        public int key;
        public Node left,right;

        public Node(int key)
        {
            this.key = key;
            
        }
    }

    
    class Program
    {
        public static Node root;
        static void Main(string[] args)
        {
            root = new Node(3);
            root.left = new Node(2);
            root.right = new Node(4);
            root.left.left = new Node(1);
            root.left.right = new Node(3);
            root.right.right = new Node(5);

            if (CheckIfTreeIsContinous(root))
            {
                Console.WriteLine("Tree is continous");
            }
            else
            {
                Console.WriteLine("Tree is Not Continous");
            }
        }

        public static bool CheckIfTreeIsContinous(Node root)
        {
            if (root==null || (root.left==null && root.right==null))
            {
                Console.WriteLine("Tree does not exist");
                return false;
            }

            Queue<Node> nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(root);
          

            while (nodeQueue.Count>0)
            {
                Node temp = nodeQueue.Peek();
                nodeQueue.Dequeue();

                if (temp.left!=null)
                {
                    if (Math.Abs((temp.left.key-temp.key))==1)
                    {
                        nodeQueue.Enqueue(temp.left);
                    }

                    else
                    {
                        return false;
                    }
                }

                if (temp.right != null)
                {
                    if (Math.Abs((temp.right.key - temp.key)) == 1)
                    {
                        nodeQueue.Enqueue(temp.left);
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            return true;

        }
    }
}
