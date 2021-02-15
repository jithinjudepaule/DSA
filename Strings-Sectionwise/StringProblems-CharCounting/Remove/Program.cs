using System;

namespace Remove
{
    /// <summary>
    /// Remove characters from the first string which are present in the second string
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string str = "geeksforgeeks";
            String mask_str = "mask";
            Console.WriteLine(RemoveDirtyChars(str, mask_str));
        }

        private static string RemoveDirtyChars(string str, string mask_str)
        {
            string removedString = "";
            int[] alphabetsCount = new int[26];
            for (int i = 0; i < str.Length; i++)
            {
                alphabetsCount[str[i] - 'a'] = 1;
            }

            for (int i = 0; i < mask_str.Length; i++)
            {
                if (alphabetsCount[mask_str[i] - 'a'] == 1)
                {
                    continue;
                }
                else
                {
                    removedString = removedString +mask_str[i];
                }
            }
            return removedString;
        }
    }
}
