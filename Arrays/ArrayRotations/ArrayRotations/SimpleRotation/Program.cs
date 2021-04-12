using System;

namespace SimpleRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int d = 2;
            RotateArrays(array, d);
        }

        static void RotateArrays(int[] array, int rotateBy)
        {
            if (rotateBy ==0)
            {
                Console.WriteLine("Array need not be rotated");
            }

            else
            {
                rotateBy = rotateBy % array.Length;

                RotateArray(array, 0, rotateBy - 1); //[ 2 1 3 4 5 6 7]
                RotateArray(array, rotateBy, array.Length - 1);//[2 1 7 6 5 4 3]
                RotateArray(array, 0, array.Length - 1);

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }

            }
        }

        private static void RotateArray(int[] array, int start, int end)
        {
            int temp = 0;
            while (start<end)
            {
                temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }
    }
}
