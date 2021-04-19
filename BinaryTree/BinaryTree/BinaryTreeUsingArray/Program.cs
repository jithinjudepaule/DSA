using System;

namespace BinaryTreeUsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree("A",10);
            binaryTree.setLeft("B", 0);
            binaryTree.setRightt("C", 0);
            binaryTree.setLeft("D", 1);
            binaryTree.setRightt("E", 1);
            binaryTree.setLeft("F", 2);
            binaryTree.setRightt("G", 2);

            for (int i = 0; i < binaryTree.treeNodes.Length; i++)
            {
                Console.WriteLine(binaryTree.treeNodes[i]);
            }
        }


    }

    public class BinaryTree
    {
        public string[] treeNodes;
        public BinaryTree(string root,int length)
        {
           treeNodes = new string[length];
            treeNodes[0] = root;
        }

        public void setLeft(string value, int level)
        {
            int node = (2 * level) + 1;

            treeNodes[node] = value;
        }

        public void setRightt(string value, int level)
        {
            int node = (2 * level) + 1 +1;

            treeNodes[node] = value;
        }
    }
}
