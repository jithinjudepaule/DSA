using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinousTree
{
    class Program
    {
        class Node
        {
            public Node left, right;
            public int key;
            public Node(int key)
            {
                this.key = key;
            }
        }
        static void Main(string[] args)
        {
            Node root = new Node(3);
            root.left = new Node(2);
            root.right = new Node(4);
            root.left.left = new Node(1);
            root.left.right = new Node(3);
            root.right.right = new Node(5);
            if (treeContinuous(root))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        private static bool treeContinuous(Node root)
        {
            if (root==null)
            {
                return true;
            }

            if (root.left==null && root.right==null)
            {
                return true;
            }

            if (root.left==null)
            {
                return (Math.Abs(root.key - root.right.key) == 1 && treeContinuous(root.right));
              
            }

            if (root.right == null)
            {
                return (Math.Abs(root.key - root.left.key) == 1 && treeContinuous(root.left));
               
            }

            return (Math.Abs(root.key - root.left.key) == 1 && Math.Abs(root.key - root.right.key) == 1 &&
                 treeContinuous(root.left) && treeContinuous(root.right));
           
        }
    }
}
