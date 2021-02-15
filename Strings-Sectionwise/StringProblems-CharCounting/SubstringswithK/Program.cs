using System;

namespace SubstringswithK
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "aabbcc";
            CheckSubstrings(testString, 2);
        }

        private static void CheckSubstrings(string testString, int k)
        {
            int count = 0;
           
            int index = 0;
            for (int i = 0; i < testString.Length; i++)
            {
                int[] frequency = new int[26];
                for (int j = i; j < testString.Length; j++)
                {
                    index = testString[j] - 'a';
                    frequency[index]++;
                    if (frequency[index]>k)
                    {
                        break;
                    }
                    else if (frequency[index] == k &&
                Check(frequency, k) == true)
                        count++;
                }
            }
            Console.WriteLine(count);
        }

        private static bool Check(int[] freq, int k)
        {
            for (int i = 0; i < freq.Length; i++)
            
                if (freq[i]!=0 && freq[i]!=k)
                
                    return false;
             

            return true;
        }
    }
}
