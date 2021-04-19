using System;

namespace FixedPointElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { -10, -5, 3, 4, 7, 9 };
           int fixedPoint= FindFixedPoint(array,0,array.Length-1);
            if (fixedPoint!=-1)
            {
                Console.WriteLine($"Fixed point is {fixedPoint}");
            }
        }

        private static int FindFixedPoint(int[] array, int low, int high)
        {
            if (high > low)
            {


                int mid = low + high / 2;
                if (array[mid] == mid)
                {
                    return mid;
                }
                else if (mid < array[mid])
                {
                  return   FindFixedPoint(array, low, mid - 1);
                }

                return FindFixedPoint(array, mid+1, high);
            }
            return -1;
        }
    }
}
