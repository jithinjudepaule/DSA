using System;

class Program
{
	static void Main()
	{
		string testSentence = "This is si test string";
		FindLargestAndSmallestWord(testSentence);
	}

	static void FindLargestAndSmallestWord(string testSentence)
	{
		string[] wordList = testSentence.Split(' ');
		string largest = wordList[0];
		string smallest = wordList[0];
		for (int i = 1; i < wordList.Length; i++)
		{
			if (wordList[i].Length > largest.Length)
			{
				largest = wordList[i];
			}


			if (wordList[i].Length < smallest.Length)
			{
				smallest = wordList[i];
			}
		}
		Console.WriteLine($"Smallest is {smallest} and Largest is {largest}");
	}
}