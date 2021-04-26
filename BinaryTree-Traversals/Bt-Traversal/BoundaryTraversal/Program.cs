using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundaryTraversal
{
	// C# program to print boundary traversal
	// of binary tree
	using System;

	/* A binary tree node has data,
	pointer to left child and a pointer
	to right child */
	public class Node
	{
		public int data;
		public Node left, right;

		public Node(int item)
		{
			data = item;
			left = right = null;
		}
	}

	class GFG
	{
		public Node root;

		// A simple function to print leaf
		// nodes of a binary tree
		public virtual void printLeaves(Node node)
		{
			if (node == null)
				return;

			printLeaves(node.left);

			// Print it if it is a leaf node
			if (node.left == null && node.right == null)
			{
				Console.Write(node.data + " ");
			}
			printLeaves(node.right);
		}

		// A function to print all left boundary
		// nodes, except a leaf node. Print the
		// nodes in TOP DOWN manner
		public virtual void printBoundaryLeft(Node node)
		{
			if (node == null)
				return;

			if (node.left != null)
			{

				// to ensure top down order, print the node
				// before calling itself for left subtree
				Console.Write(node.data + " ");
				printBoundaryLeft(node.left);
			}
			else if (node.right != null)
			{
				Console.Write(node.data + " ");
				printBoundaryLeft(node.right);
			}

			// do nothing if it is a leaf node,
			// this way we avoid duplicates in output
		}

		// A function to print all right boundary
		// nodes, except a leaf node. Print the
		// nodes in BOTTOM UP manner
		public void printBoundaryRight(Node node)
        {
            if (node==null)
            {
				return;

            }

            if (node.right!=null)
            {
				printBoundaryRight(node.right);
                Console.WriteLine(node.data);
            }

			else if (node.left != null)
			{
				printBoundaryRight(node.left);
				Console.Write(node.data + " ");
			}
		}

		// A function to do boundary traversal
		// of a given binary tree
		public virtual void printBoundary(Node node)
		{
			if (node == null)
				return;

			Console.Write(node.data + " ");

			// Print the left boundary in
			// top-down manner.
			printBoundaryLeft(node.left);

			// Print all leaf nodes
			printLeaves(node.left);
			printLeaves(node.right);

			// Print the right boundary in
			// bottom-up manner
			printBoundaryRight(node.right);
		}

		// Driver Code
		public static void Main(string[] args)
		{
			GFG tree = new GFG();
			tree.root = new Node(20);
			tree.root.left = new Node(8);
			tree.root.left.left = new Node(4);
			tree.root.left.right = new Node(12);
			tree.root.left.right.left = new Node(10);
			tree.root.left.right.right = new Node(14);
			tree.root.right = new Node(22);
			tree.root.right.right = new Node(25);
			tree.printBoundary(tree.root);
		}
	}

	// This code is contributed by Shrikant13

}
