using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace BinaryTreeDeletion
{
    class BinaryTree
    {
        public class Node
        {
            public Node left, right;
            public int key;
            public Node(int key)
            {
                this.key = key;
            }
        }

        static Node root;

        static void Main(string[] args)
        {
            root = new Node(10);
            root.left = new Node(11);
            root.left.left = new Node(7);
            root.left.right = new Node(12);
            root.right = new Node(9);
            root.right.left = new Node(15);
            root.right.right = new Node(8);
            Console.Write("Inorder traversal " +
                     "before deletion:");
            inorder(root);

            int key = 11;
            deleteNode(root, key);

            Console.Write("\nInorder traversal " +
                             "after deletion:");
            inorder(root);
        }



        private static void inorder(Node tempRoot)
        {
            if (tempRoot == null)
            {
                return;
            }

            inorder(tempRoot.left);
            Console.Write(tempRoot.key + " ");
            inorder(tempRoot.right);
        }


        private static void deleteNode(Node root, int keyToDelete)
        {
            if (root == null)
            {
                return;
            }
            if (root.left == null && root.right == null)
            {

                if (root.key == keyToDelete)
                {
                    root = null;
                    return;
                }

                else
                {
                    return;
                }
            }

            Queue<Node> nodeQueue = new Queue<Node>();
            nodeQueue.Enqueue(root);
            Node temp = null, nodeToDelete = null;

            while (nodeQueue.Count > 0)
            {
                temp = nodeQueue.Peek();
                nodeQueue.Dequeue();
                if (temp.key == keyToDelete)
                {
                    nodeToDelete = temp;
                }

                if (temp.left != null)
                {
                    nodeQueue.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    nodeQueue.Enqueue(temp.right);
                }

            }

            if (nodeToDelete != null)
            {
                int rightmostNodeKey = temp.key;
                deleteDeepest(root, temp);
                nodeToDelete.key = rightmostNodeKey;
            }
        }

        private static void deleteDeepest(Node root, Node nodeToDelete)
        {
            if (root == nodeToDelete)
            {
                root = null;
                return;
            }
            Queue<Node> nodeQueue = new Queue<Node>();
            Node tempNode = null;
            nodeQueue.Enqueue(root);

            while (nodeQueue.Count > 0)
            {
                tempNode = nodeQueue.Peek();
                nodeQueue.Dequeue();
                if (tempNode.left != null)
                {


                    if (tempNode.left == nodeToDelete)
                    {
                        tempNode.left = null;
                        return;
                    }

                    else
                    {
                        nodeQueue.Enqueue(tempNode.left);
                    }
                }

                if (tempNode.right != null)
                {
                    if (tempNode.right == nodeToDelete)
                    {
                        tempNode.right = null;
                        return;
                    }

                    else
                    {
                        nodeQueue.Enqueue(tempNode.right);
                    }
                }
            }

        }

    }
}
