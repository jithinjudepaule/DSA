// C# program to bring all spaces in front of 
// string using swapping technique 
using System;

class GFG
{

	// Function to find spaces and move to beginning 
	static void moveSpaceInFront(char[] str)
	{

		// Traverse from end and swap spaces 
		
		int i = str.Length - 1;
		for (int j = i; j >= 0; j--)
			if (str[j] != ' ')
			{
				char c = str[i];
				str[i] = str[j];
				str[j] = c;
				i--;
			}
	}

	// Driver code 
	public static void Main()
	{
		char[] str = "Hey there, it's GeeksforGeeks".ToCharArray();
		moveSpaceInFront(str);
		Console.WriteLine(String.Join("", str));
	}
}

// This code is contributed by PrinciRaj1992 
