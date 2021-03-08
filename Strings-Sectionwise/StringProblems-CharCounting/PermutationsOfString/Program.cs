using System;

namespace PermutationsOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci.PrintFibonacci(5);
            //PrintRecursively(4);
            StringPermutation.PrintStringPermutations("geeks",0,4);
        } 
        static void PrintRecursively(int num)
        {
            if (num <= 1)
            {
                return;
            }
            else
            {
                Console.WriteLine($"Before Recursion: num ={num}");
                PrintRecursively(num - 1);
                Console.WriteLine($"After Recursion: num={num}");
        }
    }
    }
}
