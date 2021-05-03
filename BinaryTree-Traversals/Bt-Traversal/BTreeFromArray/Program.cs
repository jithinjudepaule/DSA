using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTreeFromArray
{
    public class BinaryTree
    {
        static void Main(string[] args)
        {
            ArrayImplementation arrayImplementation = new ArrayImplementation(5, "A");
            arrayImplementation.SetLeft("B", 0);
            arrayImplementation.SetRight("C", 0);
            arrayImplementation.SetLeft("D", 1);
            arrayImplementation.SetRight("E", 1);

            for (int i = 0; i < ArrayImplementation.arrayRepresentation.Length; i++)
            {
                Console.WriteLine(ArrayImplementation.arrayRepresentation[i]);
            }

        }
    }

    public class ArrayImplementation
    {
        public static string[] arrayRepresentation;
        public ArrayImplementation(int size, string root)
        {
            arrayRepresentation = new string[size];
            arrayRepresentation[0] = root;
        }

       public   void SetLeft(string key, int parent)
        {
            if (arrayRepresentation[parent]==null)
            {
                Console.WriteLine("Cannot set child as no parent found");
            }
            else
            {
                arrayRepresentation[2 * parent + 1] = key;
            }
            
        }

       public  void SetRight(string key, int parent)
        {
            if (arrayRepresentation[parent] == null)
            {
                Console.WriteLine("Cannot set child as no parent found");
            }
            else
            {
                arrayRepresentation[2 * parent + 2] = key;
            }

        }
    }


}
