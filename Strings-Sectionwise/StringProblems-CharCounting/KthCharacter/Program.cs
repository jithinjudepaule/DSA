// C# program to find K'th 
// character in decrypted strinL 
using System;

class GFG
{

	// Function to find K'th 
	// character in Encoded String 
	static char encodedChar(string str, int k)
	{
		// expand string variable is 
		// used to store final string 
		// after decompressing string str 
		String expand = "";

		String temp = ""; // Current substring 
		int freq = 0; // Count of current substring 

		for (int i = 0; i < str.Length;)
		{
			temp = ""; // Current substring 
			freq = 0; // count frequency of current 
					  // substring 

			// read characters until you 
			// find a number or end of string 
			while (i < str.Length && str[i] >= 'a'
								&& str[i] <= 'z')
			{
				// push character in temp 
				temp += str[i];
				i++;
			}

			// read number for how many times 
			// string temp will be repeated 
			// in decompressed string 
			while (i < str.Length && str[i] >= '1'
								&& str[i] <= '9')
			{
				// generating frequency of temp 
				freq =  str[i] - '0';
				i++;
			}

			// now append string temp into 
			// expand equal to its frequency 
			for (int j = 1; j <= freq; j++)
				expand += temp;
		}

		// this condition is to handle 
		// the case when string str is 
		// ended with alphabets not 
		// with numeric value 
		if (freq == 0)
			expand += temp;

		return expand[k - 1];
	}

	// Driver Code 
	public static void Main()
	{
		string str = "ab4c12ed3";
		int k = 21;
		Console.Write(encodedChar(str, k));
	}
}

// This code is contributed 
// by ChitraNayal 
