using System;
using System.Collections.Generic;
using System.Text;

namespace CheckSubstrings
{
	

	public static class Substrings
	{
		public static void FindSubstrring()
		{
			String s = "Geeky";
			PrintAllSubstringsUsingFunction(s, s.Length);
			//printAllSubStrings(s, s.Length);
		
		}

		private static void PrintAllSubstringsUsingFunction(string str, int length)
		{
			HashSet<string> uniqueStrings = new HashSet<string>();
			for (int i = 0; i < length; i++)
			{
				for (int j = 1; j <length-i ; j++)
				{
					
					Console.WriteLine(str.Substring(i,j));
					if (str.Substring(i, j).Length >= 2 && !uniqueStrings.Contains(str))
					{
						uniqueStrings.Add(str.Substring(i, j));
					}
				}
			}
			string substringToPrint = "";
			int count;
			foreach (var substring in uniqueStrings)
			{
				substringToPrint = "";
				 substringToPrint +=substring[0];
				count = 1;
				for (int i = 1; i < substring.Length; i++)
				{
			
					if (!substringToPrint.Contains(substring[i]))
					{
						count++;
						substringToPrint += substring[i];
					}
					else
					{
						substringToPrint += substring[i];
						continue;
					}
				}
				if (count==2)
				{
					Console.WriteLine(substring);
				}
			}
		}

		// Function to print all (n * (n + 1)) / 2
		// subStrings of a given String s of length n.
		public static void printAllSubStrings(String str, int n)
		{
			// Fix start index in outer loop.
			// Reveal new character in inner
			// loop till end of String.
			// Print till-now-formed String.
			for (int i = 0; i < n; i++)
			{
				char[] temp = new char[n - i + 1];
				int tempindex = 0;

				for (int j = i; j < n; j++)
				{
					temp[tempindex++] = str[j];
					temp[tempindex] = '\0';
					Console.WriteLine(temp);
				}
			}
		}

		// Driver code
		
	}

	// This code is contributed by Shubhamsingh10

}
