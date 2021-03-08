// C# Program to print all 
// palindromes in a given range 
using System;

class GFG
{

	// A function to check 
	// if n is palindrome 
	public static int isPalindrome(int n)
	{

		// Find reverse of n 
		int rev = 0;
		for (int i = n; i > 0; i /= 10)
		{
			rev = rev * 10 + i % 10;
		}

		// If n and rev are same, 
		// then n is palindrome 
		return (n == rev) ? 1 : 0;
	}

	// prints palindrome between 
	// min and max 
	public static void countPal(int min,
								int max)
	{
		for (int i = min; i <= max; i++)
		{
			if (isPalindrome(i) == 1)
			{
				Console.Write(i + " ");
			}
		}
	}

	// Driver Code 
	public static void Main(string[] args)
	{
		countPal(100, 2000);
	}
}

// This code is contributed by Shrikant13 
