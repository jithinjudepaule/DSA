using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerticalTraversal
{
    // C# program to implement the 
    // above approach
    using System;
    using System.Collections;
    using System.Collections.Generic;
    class Node
    {

        public int key;
        public Node left, right;

        // A utility function to 
        // create a new node
        public Node newNode(int key)
        {
            Node node = new Node();
            node.key = key;
            node.left = node.right =
                        null;
            return node;
        }
    }

    class QueueObject
    {

        public int hdistance;
        public Node node;
        public QueueObject(int hdistance,
                    Node node)
        {
            this.hdistance = hdistance;
            this.node = node;
        }
    }

    class VerticalOrderTraversal
    {

        // The main function to print 
        // vertical oder of a binary 
        // tree with given root
        static void printVerticalOrder(Node root)
        {
            // Base case
            if (root == null)
                return;

            SortedDictionary<int, List<int>> keyValuePairs = new SortedDictionary<int, List<int>>();
            Queue<QueueObject> queueObjects = new Queue<QueueObject>();
            queueObjects.Enqueue(new QueueObject(0, root));

            while (queueObjects.Count!=0)
            {
                QueueObject tempQ = queueObjects.Dequeue();
                Node tempNode = tempQ.node;
                int  hdistance = tempQ.hdistance;
                if (keyValuePairs.ContainsKey(hdistance))
                {
                    keyValuePairs[hdistance].Add(tempNode.key);
                }
                else
                {
                    keyValuePairs.Add(hdistance, new List<int>() { tempNode.key });
                }

                if (tempNode.left!=null)
                {
                    queueObjects.Enqueue(new QueueObject(hdistance - 1, tempNode.left));
                }

                if (tempNode.right != null)
                {
                    queueObjects.Enqueue(new QueueObject(hdistance + 1, tempNode.right));
                }

            }

            foreach (var item in keyValuePairs)
            {
                
                    foreach (var nodeValue in item.Value)
                    {
                        Console.Write(nodeValue+" ");
                    }
                Console.WriteLine();
                
               
            }
        }

        // Driver code
        public static void Main(string[] arr)
        {
            Node n = new Node();
            Node root;
            root = n.newNode(1);
            root.left = n.newNode(2);
            root.right = n.newNode(3);
            root.left.left = n.newNode(4);
            root.left.right = n.newNode(5);
            root.right.left = n.newNode(6);
            root.right.right = n.newNode(7);
            //root.right.left.right = n.newNode(8);
            //root.right.right.right = n.newNode(9);
            //root.right.right.left = n.newNode(10);
            //root.right.right.left.right = n.newNode(11);
            //root.right.right.left.right.right = n.newNode(12);
            Console.Write("Vertical order traversal is \n");
            printVerticalOrder(root);
        }
    }

    // This code is contributed by Rutvik_56
}
