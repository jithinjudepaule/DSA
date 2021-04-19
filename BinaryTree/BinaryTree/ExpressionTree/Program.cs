using System;
using System.Collections.Generic;

namespace ExpressionTree
{


	public class Node
	{

		public char value;
		public Node left, right;

		public Node(char item)
		{
			value = item;
			
		}
	}

	class ExpressionTree
	{

		// A utility function to check if 'c'
		// is an operator
		Boolean isOperator(char c)
		{
			if (c == '+' || c == '-' || c == '*'
				|| c == '/' || c == '^')
			{
				return true;
			}
			return false;
		}

	

		// Driver code
		public static void Main(String[] args)
		{
			ExpressionTree et = new ExpressionTree();
			String postfix = "ab+ef*g*-";
			char[] charArray = postfix.ToCharArray();
			Node root = et.constructTree(charArray);
			Console.WriteLine("infix expression is");
			et.inorder(root);
		}

        private void inorder(Node root)
        {
            if (root!=null)
            {
				inorder(root.left);
                Console.Write(root.value + " ");
				inorder(root.right);
            }
        }

        private Node constructTree(char[] charArray)
        {
			Node tempNode;
			Stack<Node> stack = new Stack<Node>();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (!isOperator(charArray[i]))
                {
					tempNode = new Node(charArray[i]);
					stack.Push(tempNode);
                }

                else
                {
					tempNode = new Node(charArray[i]);
					tempNode.right = stack.Pop();
					tempNode.left = stack.Pop();
					stack.Push(tempNode);
				}
            }

			Node root = stack.Pop();
			return root;
            
        }
    }

	// This code has been contributed by Arnab Kundu

}
