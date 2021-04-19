using System;

namespace RotateArray
{
    class Program
    {
		static public void Main()
		{
			int[] array = new int[] { 1, 2, 3, 4, 5 };
			int arraySize = 5;
			int rotationNumber = 2;
			RotateArrayClockwise(array, rotationNumber, arraySize);
			PrintArrayClockwise(array,arraySize);
			
			array = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
			RotateArrayClockwise(array, 3, 10);
			PrintArrayClockwise(array, 10);
		}

		private static void PrintArrayClockwise(int[] array, int n)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i]+" ");
			}
		}

		private static void RotateArrayClockwise(int[] array, int rotationNumber, int arraySize)
		{
			int[] arrayTemp = new int[rotationNumber];

			for (int j = 0; j < rotationNumber; j++)
			{
				arrayTemp[j] = array[j];
			}
			
			
			int newArrayIndex = 0;
		
			for (int i = rotationNumber; i < array.Length; i++)
			{
				array[newArrayIndex] = array[i];
				newArrayIndex++;
			}
			int n = rotationNumber;

			for (int k = 0; k < rotationNumber; k++)
			{
				array[array.Length - n] = arrayTemp[k];
				n--;
			}
		}
	}
}
