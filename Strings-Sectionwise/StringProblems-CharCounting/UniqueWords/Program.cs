// C# program to print all words that 
// have the same unique character set 
using System;
using System.Collections.Generic;

class GFG
{

	static readonly int MAX_CHAR = 26;

	// Generates a key from given string. The 
	// key contains all unique characters of 
	// given string in sorted order consisting 
	// of only distinct elements. 
	static String getKey(String str)
	{
		bool[] visited = new bool[MAX_CHAR];

		// Store all unique characters of current 
		// word in key 
		for (int j = 0; j < str.Length; j++)
			visited[str[j] - 'a'] = true;

		String key = "";

		for (int j = 0; j < MAX_CHAR; j++)
			if (visited[j])
				key = key + (char)('a' + j);

		return key;
	}

	// Print all words together with same character sets. 
	static void wordsWithSameCharSet(String[] words, int n)
	{

		// Stores indexes of all words that have same 
		// set of unique characters. 
		//unordered_map <string, vector <int> > Hash; 
		Dictionary<String,
				List<int>> Hash = new Dictionary<String,
													List<int>>();

		// Traverse all words 
		for (int i = 0; i < n; i++)
		{
			String key = getKey(words[i]);

			// If the key is already in the map 
			// then get its corresponding value 
			// and update the list and put it 
			// in the map 
			if (Hash.ContainsKey(key))
			{
				List<int> get_al = Hash[key];
				get_al.Add(i);
				Hash[key] = get_al;
			}

			// If key is not present in the map 
			// then create a new list and add 
			// both key and the list 
			else
			{
				List<int> new_al = new List<int>();
				new_al.Add(i);
				Hash.Add(key, new_al);
			}
		}

		// Print all words that have the 
		// same unique character set 
		foreach (KeyValuePair<String, List<int>> it in Hash)
		{
			List<int> get = it.Value;
			foreach (int v in get)
				Console.Write(words[v] + ", ");

			Console.WriteLine();
		}
	}

	// Driver code 
	public static void Main(String[] args)
	{
		String[] words = { "may", "student", "students",
					"dog", "studentssess", "god",
					"cat", "act", "tab",
					"bat", "flow", "wolf",
					"lambs", "amy", "yam",
					"balms", "looped", "poodle"};

		int n = words.Length;

		wordsWithSameCharSet(words, n);
	}
}

// This code is contributed by Princi Singh
