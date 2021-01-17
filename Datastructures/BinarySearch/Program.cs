using System;

namespace BinarySearch
{
	// C# implementation of recursive Binary Search 
	using System;



	class Program
	{
		// Returns index of x if it is present in 
		// arr[l..r], else return -1  { 2, 3, 4, 10, 40 }
		static int binarySearch(int[] array, int startIndex,
								int arrayLength, int searchElement)
		{

				
			if (arrayLength >= startIndex)
			{
				int mid = startIndex + (arrayLength - startIndex) / 2;
				if (array[mid] == searchElement)
				{
					return mid;
				}
				if (searchElement < array[mid])
				{
					return binarySearch(array, startIndex, mid - 1, searchElement);
				}

				else
				{
					return binarySearch(array, mid + 1, arrayLength, searchElement);
				}
			}
			return -1;
		}

		// Driver method to test above 
		public static void Main()
		{

			int[] arr = { 2, 3, 4, 10, 40 };
			int arrayLength = arr.Length;
			int searchElement = 10;

			int result = binarySearch(arr, 0, arrayLength - 1, searchElement);

			if (result == -1)
				Console.WriteLine("Element not present");
			else
				Console.WriteLine("Element found at index "
								+ result);
		}
	}

	

}
