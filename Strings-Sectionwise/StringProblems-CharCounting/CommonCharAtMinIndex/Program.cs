using System;

namespace CommonCharAtMinIndex
{
    /// <summary>
    /// Find the character in first string that is present at minimum index in second string
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string testString1 = "geeks";
            string test2 = "set";
            CheckChar(testString1, test2);
        }

        private static void CheckChar(string testString1, string test2)
        {
            int[] alphaCount = new int[26];
            int charFound = -1;
            for (int i = 0; i < testString1.Length; i++)
            {
                alphaCount[testString1[i] - 'a']++;
            }

            for (int i = 0; i < test2.Length; i++)
            {
                if (alphaCount[test2[i]-'a']>0)
                {
                    alphaCount[test2[i] - 'a'] = -2;
                }
            }

            for (int i = 0; i < alphaCount.Length; i++)
            {
                if (alphaCount[i]==-2)
                {
                    charFound = i + 'a';
                    break;
                }
            }

            if (charFound==-1)
            {
                Console.WriteLine("no char found common");
            }
            else
            {
                Console.WriteLine($"Common char is {(char)charFound}");
            }
        }
    }
}
