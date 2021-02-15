using System;
using System.Collections.Generic;
using System.Text;

namespace PermutationsOfString
{
   public static class Fibonacci
    {
       public static void PrintFibonacci(int num)
        {
            Console.WriteLine($"Fibonacci({num}) is ");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{CalculateFibonacci(i)}");
            }
        }
       public static int CalculateFibonacci(int num)
        {
            if (num==0)
            {
                return 0;
            }
            if (num==1 || num==2)
            {
                return 1;
            }

            else
            {
                return (CalculateFibonacci(num - 1) + CalculateFibonacci(num - 2));
            }
        }
    }
}
