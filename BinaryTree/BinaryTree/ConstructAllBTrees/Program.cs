using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructAllBTrees
{
	// C# program to find binary tree
	// with given inorder traversal
	using System;
	using System.Collections.Generic;

	/* Class containing left and right
	child of current node and key value*/
	public class Node
	{
		public int data;
		public Node left, right;

		public Node(int item)
		{
			data = item;
			left = null;
			right = null;
		}
	}

	/* Class to print Level Order Traversal */
	class GFG
	{
		public Node root;

		// A utility function to do
		// preorder traversal of BST
		public virtual void preOrder(Node node)
		{
			if (node != null)
			{
				Console.Write(node.data + " ");
				preOrder(node.left);
				preOrder(node.right);
			}
		}

		// Function for constructing all possible
		// trees with given inorder traversal
		// stored in an array from arr[start] to
		// arr[end]. This function returns a
		// vector of trees.
		public virtual List<Node> getTrees(int[] arr,
										int start,
										int end)
		{

			// List to store all possible trees
			List<Node> trees = new List<Node>();

			/* if start > end then subtree will be
			empty so returning NULL in the list */
			if (start > end)
			{
				trees.Add(null);
				return trees;
			}

			/* Iterating through all values from
			start to end for constructing left
			and right subtree recursively */
			for (int i = start; i <= end; i++)
			{
				/* Constructing left subtree */
				List<Node> ltrees = getTrees(arr, start, i - 1);

				/* Constructing right subtree */
				List<Node> rtrees = getTrees(arr, i + 1, end);

				/* Now looping through all left and
				right subtrees and connecting them
				to ith root below */
				for (int j = 0; j < ltrees.Count; j++)
				{
					for (int k = 0; k < rtrees.Count; k++)
					{

						// Making arr[i] as root
						Node node = new Node(arr[i]);

						// Connecting left subtree
						node.left = ltrees[j];

						// Connecting right subtree
						node.right = rtrees[k];

						// Adding this tree to list
						trees.Add(node);
					}
				}
			}
			return trees;
		}

		// Driver Code
		public static void Main(string[] args)
		{
			int[] arr = new int[] { 4, 5, 7 };
			int n = arr.Length;
			GFG tree = new GFG();
			List<Node> trees = tree.getTrees(arr, 0, n - 1);
			Console.WriteLine("Preorder traversal of different " +
											" binary trees are:");
			for (int i = 0; i < trees.Count; i++)
			{
				tree.preOrder(trees[i]);
				Console.WriteLine("");
			}
		}
	}

	// This code is contributed by Shrikant13

}
