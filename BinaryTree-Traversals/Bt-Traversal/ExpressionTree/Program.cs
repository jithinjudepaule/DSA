using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTree
{
    class Program
    {
        public class Node
        {
            public Node left, right;
            public char key;

            public Node(char key)
            {
                this.key = key;
            }
        }


        static void Main(string[] args)
        {
            String postfix = "ab+ef*g*-";
            char[] charArray = postfix.ToCharArray();
            Node root =constructTree(charArray);
            Console.WriteLine("infix expression is");
            inorder(root);
        }

        private static void inorder(Node root)
        {
            if (root==null)
            {
                return;
            }
            inorder(root.left);
            Console.Write(root.key +" ");
            inorder(root.right);
        }

        private static Node constructTree(char[] charArray)
        {
            Node root;
            Stack<Node> stackNode = new Stack<Node>();
            foreach (var item in charArray)
            {
                if (CheckIfOperator(item))
                {
                    root = new Node(item);
                    root.left = stackNode.Pop();
                    root.right = stackNode.Pop();
                    stackNode.Push(root);
                }

                else
                {
                    root = new Node(item);
                    stackNode.Push(root);
                }

            }
            root = stackNode.Pop();
            return root;
        }

        private static bool CheckIfOperator(char c)
        {
            if (c=='+'|| c == '-'||c == '*'||c=='/')
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
