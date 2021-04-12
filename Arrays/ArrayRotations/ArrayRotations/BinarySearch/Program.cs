using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
                                 // 0  1  2  3   4   5   6   7
            int[] arr = new int[] { 2, 6, 9, 15, 21, 27, 33, 45 };
            int searchElement = 2;
            int index = 0;

           index= FindUsingBinarySearch(arr, searchElement,0,arr.Length-1);
            if (index>=0)
            {
                Console.WriteLine($"Search Element found at {index} ");
            }
            else
            {
                Console.WriteLine("index not found");
            }
        }

        static int FindUsingBinarySearch(int[] array, int searchElement,int low, int high)
        {
           
            if (low<=high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == searchElement)
                {
                    
                    return mid;
                }
                if (array[mid] > searchElement)
                {
                  return  FindUsingBinarySearch(array, searchElement, low, mid - 1);
                }

                else
                {
                   return FindUsingBinarySearch(array, searchElement, mid + 1, high);
                }
            }

            return -1;
           
        }
    }
}
