﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOrderTraversal
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
            root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);

            PostOrder(root);

        }

        static void PostOrder(Node temp)
        {
            if (temp == null)
            {
                return;
            }
            PostOrder(temp.left);
            PostOrder(temp.right);
            Console.Write(temp.key + " ");

        }
    }
}