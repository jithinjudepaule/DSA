using System;
using System.Collections.Generic;

namespace DuplicatesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 1, 3, 5, 3, 1 };
            //findDuplicates(array);
           findRepeatingUsingHashset(array);

        }

        static void findDuplicates(int[] array)
        {
            int j = 0;
            while (j<array.Length-1)
            {
                for (int i = j; i < array.Length - 1; i++)
                {
                    if (array[j] == array[i + 1])
                    {
                        Console.WriteLine(array[j]);
                    }
                }
                j++;
            }
           
        }

        static int findRepeatingUsingHashset(int[] arr)
        {
            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (s.Contains(arr[i]))
                    Console.WriteLine(arr[i]);
                s.Add(arr[i]);
            }
            
            // If input is correct, we should  
            // never reach here  
            return -1;
        }
    }
}
