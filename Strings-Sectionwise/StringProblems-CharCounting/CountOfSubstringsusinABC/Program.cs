// C# program to count number 
// of strings of n characters 
// with a, b and c under given 
// constraints 
using System;

class GFG
{

	// n is total number of 
	// characters. bCount and 
	// cCount are counts of 
	// 'b' and 'c' respectively. 
	static int countStr(int n,
						int bCount,
						int cCount)
	{
		// Base cases 
		if (bCount < 0 || cCount < 0)
			return 0;
		if (n == 0) return 1;
		if (bCount == 0 && cCount == 0)
			return 1;

		// Three cases, we choose, 
		// a or b or c. In all three 
		// cases n decreases by 1. 
		int res = countStr(n - 1,
						bCount, cCount);
		res += countStr(n - 1,
						bCount - 1, cCount);
		res += countStr(n - 1,
						bCount, cCount - 1);

		return res;
	}

	// Driver code 
	static public void Main()
	{
		// Total number 
		// of characters 
		int n = 3;
		Console.WriteLine(countStr(n, 1, 2));
	}
}

// This code is contributed by aj_36 
