using System.Linq;
using System;

class Program
{
	// Driver Code
	public static void Main()
	{
		int[] arr = { -2, 5, 3, 1,
					2, 6, -4, 2 };
		int n = arr.Length;
		Console.Write(findMaxSum(arr, n));
	}

	private static int findMaxSum(int[] array, int n)
	{
		int sum = array.Aggregate(func: FindArrayAggregate);
		int preSum = 0;
		int maxSum = int.MinValue;
		for (int i = 0; i < n; i++)
		{
			preSum = preSum + array[i];
			if (preSum==sum)
			{
				maxSum = Math.Max(maxSum,preSum);
			}
			sum = sum - array[i];
		}
		return maxSum;
	}

	private static int FindArrayAggregate(int arg1, int arg2)
	{
		return arg1 + arg2;
	}
}


