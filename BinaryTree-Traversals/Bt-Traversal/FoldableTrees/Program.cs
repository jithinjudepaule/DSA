using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldableTrees
{
    class Program
    {
        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int key)
            {
                this.key = key;
            }
        }

        public static Node root;
        static void Main(string[] args)
        {
            root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.right = new Node(5);
            root.right.left = new Node(4);

            if (IsFoldable(root))
            {
                Console.WriteLine("Is Foldable");
            }
            else
            {
                Console.WriteLine("Is Not Foldable");
            }
        }

        private static bool IsFoldable(Node root)
        {
            if (root==null)
            {
                return true;
            }

            return IsFoldableUtil(root.left, root.right);
        }

        private static bool IsFoldableUtil(Node node1, Node node2)
        {
            if (node1==null && node2 == null)
            {
                return true;
            }

            if (node1 == null || node2 == null)
            {
                return false;
            }

            return IsFoldableUtil(node1.right, node2.left) && IsFoldableUtil(node1.left, node2.right);
        }
    }
}
