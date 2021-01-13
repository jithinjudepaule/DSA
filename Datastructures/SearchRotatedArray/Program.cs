using System;

namespace SearchRotatedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the test cases");
            int testCasesNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of array ");
            int lengthOfArray = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[lengthOfArray];
            
            Console.WriteLine("Enter the array:");
            for (int i = 0; i < lengthOfArray; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter Search Element");
            int searchElement = Convert.ToInt32(Console.ReadLine());

            int index = FindIndexOfElement(array, searchElement);

            Console.WriteLine(index);
        }

        private static int FindIndexOfElement(int[] array, int searchElement)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (searchElement == array[i])
                {
                    return i;
                }
            }
            return -1;
            
        }
    }
}
