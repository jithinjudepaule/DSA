using System;

namespace PeakElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, -7, -5, 1, 9, 6, 4 };
            int peakElement = FindPeakElement(array, 0, array.Length - 1);
            Console.WriteLine($"Peak element is {peakElement}");
        }

        static int FindPeakElement(int[] array,int low, int high)
        {
            int mid = (low + high) / 2;

            if ((mid==0||array[mid]>=array[mid-1])&&(mid==array.Length-1||array[mid]>=array[mid+1]))
            {
                return mid;
            }
            else if (mid>0&&array[mid]<array[mid-1])
            {
                return FindPeakElement(array, 0, mid - 1);
            }
            else
            {
                return FindPeakElement(array, mid+1, high);
            }
        }
    }
}
