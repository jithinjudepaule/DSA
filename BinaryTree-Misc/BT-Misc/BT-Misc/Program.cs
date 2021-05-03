using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Misc
{
	// C# Program for Lowest Common
	// Ancestor in a Binary Tree
	// A O(n) solution to find LCA
	// of two given values n1 and n2
	using System.Collections;
	using System;

	// A Binary Tree node
	class Node
	{
		public int data;
		public Node left, right;

		public Node(int value)
		{
			data = value;
			left = right = null;
		}
	}

	public class BT_NoParentPtr_Solution1
	{

		Node root;
	

		// Driver code
		public static void Main(String[] args)
		{
			BT_NoParentPtr_Solution1 tree =
				new BT_NoParentPtr_Solution1();

			tree.root = new Node(1);
			tree.root.left = new Node(2);
			tree.root.right = new Node(3);
			tree.root.left.left = new Node(4);
			tree.root.left.right = new Node(5);
			tree.root.right.left = new Node(6);
			tree.root.right.right = new Node(7);

			Console.Write("LCA(4, 5): " +
							tree.findLCA(4, 5));
		
		}
	}

	// This code is contributed by Rutvik_56

}
