using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTreeFromArray
{
	// C# program to construct binary tree from
	// given array in level order fashion
	using System;

	public class Tree
	{
		Node root;

		// Tree Node
		public class Node
		{
			public int data;
			public Node left, right;
			public Node(int data)
			{
				this.data = data;
				this.left = null;
				this.right = null;
			}
		}

		// Function to insert nodes in level order
		public Node insertLevelOrder(int[] arr,
								 int i)
		{
			if (i >= arr.Length) return null;

			var node = new Node(arr[i]);
			node.left = insertLevelOrder(arr, 2 * i + 1);
			node.right = insertLevelOrder(arr, 2 * i + 2);

			return node;
		}

		// Function to print tree
		// nodes in InOrder fashion
		public void inOrder(Node root)
		{
			if (root != null)
			{
				inOrder(root.left);
				Console.Write(root.data + " ");
				inOrder(root.right);
			}
		}

		// Driver code
		public static void Main(String[] args)
		{
			Tree t2 = new Tree();
			int[] arr = { 1, 2, 3};
			//t2.root = t2.insertLevelOrder(arr, 0);
			t2.BinaryTreeUsingArray(arr);
			t2.inOrder(t2.root);
		}

		Node BinaryTreeUsingArray(int[] array)
		{
			Node tempNode = new Node(0);
			Queue<Node> queueNode = new Queue<Node>();
			Node root = tempNode;
			queueNode.Enqueue(tempNode);
		
			int n = array.Length / 2;
            for (int i = 0; i < array.Length / 2; i++)
            {
				 tempNode = queueNode.Peek();

                if ((2*i+1)<array.Length)
                {
					tempNode.left = new Node(array[2 * i + 1]);
					
                    if (n!=0)
                    {
						queueNode.Enqueue(tempNode.left);
						n--;
					}
                }

				if ((2 * i + 2) < array.Length)
				{
					tempNode.right = new Node(array[2 * i + 2]);
					
					if (n != 0)
					{
						queueNode.Enqueue(tempNode.right);
						n--;
					}
				}

			}
			return root;
		}


	}


}
