// C# program to find count of substring 
// containing exactly K ones 
using System;

public class GFG
{

	// method returns total number of 
	// substring having K ones 
	static int countOfSubstringWithKOnes(
						string str, int K)
	{
		int N = str.Length;
		int res = 0;
		int countOfOne = 0;
		int[] freq = new int[N + 1];

		// initialize index having zero 
		// sum as 1 
		freq[0] = 1;

		// loop over binary characters 
		// of string 
		for (int i = 0; i < N; i++)
		{

			// update countOfOne variable 
			// with value of ith character 
			countOfOne += (str[i] - '0');

			// if value reaches more than 
			// K, then update result 
			if (countOfOne >= K)
			{

				// add frequency of indices, 
				// having sum (current sum - K), 
				// to the result 
				res += freq[countOfOne - K];
			}

			// update freqency of one's count 
			freq[countOfOne]++;
		}

		return res;
	}

	// Driver code to test above methods 
	static public void Main()
	{
		string s = "100101";
		int K = 2;

		Console.WriteLine(
			countOfSubstringWithKOnes(s, K));
	}
}

// This code is contributed by vt_m. 
