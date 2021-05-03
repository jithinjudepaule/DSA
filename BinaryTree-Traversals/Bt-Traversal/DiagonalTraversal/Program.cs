using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalTraversal
{
	// C# program to con string from binary tree
	using System;
	using System.Collections;

	class GFG
	{

		// A binary tree node has data,
		// pointer to left child and
		// a pointer to right child
		public class Node
		{
			public int data;
			public Node left, right;
		};

		// Helper function that
		// allocates a new node
		static Node newNode(int data)
		{
			Node node = new Node();
			node.data = data;
			node.left = node.right = null;
			return (node);
		}

		// Iterative function to print diagonal view
		static void diagonalPrint(Node root)
		{
			// base case
			if (root == null)
				return;

			// inbuilt queue of Treenode
			Queue q = new Queue();

			// Enqueue root
			q.Enqueue(root);

			// Enqueue delimiter
			q.Enqueue(null);

			while (q.Count > 0)
			{
				Node temp = (Node)q.Peek();
				q.Dequeue();

				// if current is delimiter then insert another
				// for next diagonal and cout nextline
				if (temp == null)
				{

					// if queue is empty return
					if (q.Count == 0)
						return;

					// output nextline
					Console.WriteLine();

					//// Enqueue delimiter again
					q.Enqueue(null);
				}
				else
				{
					while (temp != null)
					{
						Console.Write(temp.data + " ");

						// if left child is present
						// Enqueue into queue
						if (temp.left != null)
							q.Enqueue(temp.left);

						// current equals to right child
						temp = temp.right;
					}
				}
			}
		}

		// Driver Code
		public static void Main(String[] args)
		{
			Node root = newNode(8);
			root.left = newNode(3);
			root.right = newNode(10);
			root.left.left = newNode(1);
			root.left.right = newNode(6);
			root.right.right = newNode(14);
			root.right.right.left = newNode(13);
			root.left.right.left = newNode(4);
			root.left.right.right = newNode(7);
			diagonalPrint(root);
		}
	}

	// This code is contributed by Arnab Kundu

}
