// C# program to print distinct characters 
// of a string. 
using System;

public class GFG
{

	static int NO_OF_CHARS = 256;

	/* Print duplicates present in the 
	passed string */
	static void printDistinct(String str)
	{

		// Create an array of size 256 and 
		// count of every character in it 
		int[] count = new int[NO_OF_CHARS];

		/* Count array with frequency of 
		characters */
		int i;

		for (i = 0; i < str.Length; i++)
			if (str[i] != ' ')
				count[(int)str[i]]++;

		int n = i;

		// Print characters having count 
		// more than 0 
		for (i = 0; i < n; i++)
			if (count[(int)str[i]] == 1)
				Console.Write(str[i]);
	}

	/* Driver program*/
	public static void Main()
	{
		String str = "GeeksforGeeks";

		printDistinct(str);
	}
}

// This code is contributed by parashar. 
