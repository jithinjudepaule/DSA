using System;

// basic logic --- swap-permute-swap
class Program
{
	static void Main()
    {
        int factorial = FindFactorial(4);
        Console.WriteLine(factorial);
    }

    private static int FindFactorial(int num)
    {
        if (num<=1)
        {
            return 1;
        }
        Console.WriteLine($"num={num}");
        return num * FindFactorial(num - 1);
    
    }
}


