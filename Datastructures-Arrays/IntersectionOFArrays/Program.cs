
using System;
using System.Collections.Generic;

public class Program
    {
   static void Main()
    {
        int[] array1 = { 2, 5, 7, 8, 13 };
        int[] array2 = { 3, 7, 13, 15, 17 };
        int[] array3 = { 3, 7,11, 13, 17,19 };

        int[] intersectedArrays = intersectArrays(array1, array2, array3);
   }

    static int[] intersectArrays(int[] array1, int[] array2, int[] array3)
    {
        int j = 0;
        int i = 0;
        int k = 0;
        int[] intersectedArray = new int[] { };
        List<int> intersectedList = new List<int>();
        int arrayIndex = 0;

        while (i<array1.Length && j<array2.Length && k<array3.Length)
        {
            if (array1[i] == array2[j] && array2[j] == array3[k])
            {
                // intersectedArray[arrayIndex] = array1[i];
                intersectedList.Add(array1[i]);
                i++;
                j++;
                k++;
            }

          else  if (array1[i]<array2[j])
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
        return intersectedList.ToArray();

    }
 }
