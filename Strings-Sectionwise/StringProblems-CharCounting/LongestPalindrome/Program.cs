﻿using System;

namespace LongestPalindrome
{
	

	class GFG
	{
		// A utility function to print 
		// a substring str[low..high] 
		public static void printSubStr(string str,
									int low, int high)
		{
			Console.WriteLine(str.Substring(low,
											(high + 1) - low));
		}

		// This function prints the longest 
		// palindrome substring (LPS) of str[]. 
		// It also returns the length of the 
		// longest palindrome 
		public static int longestPalSubstr(string str)
		{
			int maxLength = 1; // The result (length of LPS) 

			int start = 0;
			int len = str.Length;

			int low, high;

			// One by one consider every 
			// character as center point 
			// of even and length palindromes 
			for (int i = 1; i < len; ++i)
			{
				// Find the longest even length 
				// palindrome with center points 
				// as i-1 and i. 
				low = i - 1;
				high = i;
				while (low >= 0 && high < len && str[low] == str[high])
				{
					if (high - low + 1 > maxLength)
					{
						start = low;
						maxLength = high - low + 1;
					}
					--low;
					++high;
				}

				// Find the longest odd length 
				// palindrome with center point as i 
				low = i - 1;
				high = i + 1;
				while (low >= 0 && high < len && str[low] == str[high])
				{
					if (high - low + 1 > maxLength)
					{
						start = low;
						maxLength = high - low + 1;
					}
					--low;
					++high;
				}
			}

			Console.Write("Longest palindrome substring is: ");
			printSubStr(str, start, start + maxLength - 1);

			return maxLength;
		}

		// Driver Code 
		public static void Main(string[] args)
		{
			string str = "malayalam";
			Console.WriteLine("Length is: " + longestPalSubstr(str));
		}
	}

	// This code is contributed by Shrikant13 

}