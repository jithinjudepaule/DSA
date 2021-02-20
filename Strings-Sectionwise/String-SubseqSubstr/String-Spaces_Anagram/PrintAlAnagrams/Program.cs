// C# Program to find minimum number
// of manipulations required to make
// two strings identical
using System;

public class GFG
{

	// Counts the no of manipulations
	// required
	static int countManipulations(string s1,
								string s2)
	{
		int count = 0;

		// store the count of character
		int[] char_count = new int[26];

		// iterate though the first String
		// and update count
		for (int i = 0; i < s1.Length; i++)
			char_count[s1[i] - 'a']++;

		// iterate through the second string
		// update char_count.
		// if character is not found in
		// char_count then increase count
		for (int i = 0; i < s2.Length; i++)
		{ 
			char_count[s2[i] - 'a']--;

		
			if (char_count[s2[i] - 'a'] < 0)
			{
				count += Math.Abs(char_count[s2[i] - 'a']);
			}
		}

		return count;
	}

	// Driver code
	public static void Main()
	{

		string s1 = "ddcf";
		string s2 = "cedk";

		Console.WriteLine(
			countManipulations(s1, s2));
	}
}

// This code is contributed by vt_m. 
