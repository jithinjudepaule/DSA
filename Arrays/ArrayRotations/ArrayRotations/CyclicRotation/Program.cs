using System;

namespace CyclicRotation
{
	// C# code for program to cyclically
	// rotate an array by one
	using System;

	public class Test
	{
		static int[] arr = new int[] { 1, 2, 3, 4, 5 };

		// Method for rotation
		static void rotate()
		{
			int x = arr[arr.Length - 1], i;

			for (i = arr.Length - 1; i > 0; i--)
				arr[i] = arr[i - 1];
			arr[0] = x;
		}

		// Driver Code
		public static void Main()
		{
			Console.WriteLine("Given Array is");
			string Original_array = string.Join(" ", arr);
			Console.WriteLine(Original_array);

			rotate();

			Console.WriteLine("Rotated Array is");
			string Rotated_array = string.Join(" ", arr);
			Console.WriteLine(Rotated_array);
		}
	}

	// This code is contributed by vt_m.

}
