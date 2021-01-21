using System;

namespace CommonIn3Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 2, 4, 6, 8, 9, 10 };
            int[] array2 = new int[] { 1, 3, 6, 9, 10, 13 };
            int[] array3 = new int[] {5,7,9,11,13 };
            findCommon(array1,array2,array3);
        }

        private static void findCommon(int[] array1, int[] array2, int[] array3)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while (i<array1.Length && j<array2.Length && k<array3.Length)
            {

                if (array1[i] == array2[j] && array2[j] == array3[k])
                {
                    Console.WriteLine(array3[k]);
                    i++; j++; k++;
                }
                else if (array1[i] < array2[j])
                {
                    i++;
                }

                else if (array2[j] < array3[k])
                {
                    j++;
                }
                else
                {
                    k++;
                }
            }
        }
    }
}
