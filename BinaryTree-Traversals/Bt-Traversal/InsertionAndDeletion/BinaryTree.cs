using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionAndDeletion
{
    class BinaryTree
    {
        static Node root;
        class Node
        {
            internal Node left, right;
            internal int key;
            public Node(int key)
            {
                this.key = key;
            }
        }
        static void Main(string[] args)
        {
            root = new Node(10);
            root.left = new Node(11);
            root.right = new Node(9);
            root.left.left = new Node(7);
            root.left.right = new Node(12);
            root.right.left = new Node(15);
            root.right.right = new Node(8);

            //InsertNode(root, 12);
            //PreOrder(root);
            DeleteNode(root, 12);
            PreOrder(root);

        }

        private static void DeleteNode(Node root, int keyToDelete)
        {
            Queue<Node> qNode = new Queue<Node>();
            qNode.Enqueue(root);
            Node nodeToDelete = null;
            Node temp =null;
            while (qNode.Count > 0)
            {
                 temp = qNode.Dequeue();
                if (temp.key == keyToDelete)
                {
                    nodeToDelete = temp;
                }
                if (temp.left!=null)
                {
                    
                    qNode.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    
                    qNode.Enqueue(temp.right);
                }
            }

            int KeyToreplace = temp.key;

            DeleteAndReplaceNode(root, temp);
            nodeToDelete.key = KeyToreplace;

        }

        private static void DeleteAndReplaceNode(Node root,Node nodeToDelete)
        {
            Queue<Node> qNode = new Queue<Node>();
            qNode.Enqueue(root);

            while (qNode.Count>0)
            {
                Node temp = qNode.Dequeue();
                if (temp == nodeToDelete)
                {
                    temp = null;
                    return;

                }
                if (temp.right != null)
                {
                    if (temp.right == nodeToDelete)
                    {
                        temp.right = null;
                        return;
                    }
                    else
                        qNode.Enqueue(temp.right);
                }

                if (temp.left != null)
                {
                    if (temp.left == nodeToDelete)
                    {
                        temp.left = null;
                        return;
                    }
                    else
                        qNode.Enqueue(temp.left);
                }
            }



        }

        private static void InsertNode(Node root, int keyToInsert)
        {
            Queue<Node> qNode = new Queue<Node>();
            qNode.Enqueue(root);
            while (qNode.Count>0)
            {
                Node temp = qNode.Dequeue();

                if (temp.left==null)
                {
                    temp.left = new Node(keyToInsert);
                    return;
                }

                else
                {
                    qNode.Enqueue(temp.left);
                }

                if (temp.right == null)
                {
                    temp.right = new Node(keyToInsert);
                    return;
                }

                else
                {
                    qNode.Enqueue(temp.right);
                }

            }
            
        }

        static void PreOrder(Node temp)
        {
            if (temp == null)
            {
                return;
            }
            Console.Write(temp.key + " ");
            PreOrder(temp.left);
            PreOrder(temp.right);
           

        }
    }
}
