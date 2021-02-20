using System;

namespace AnagramCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "silent";
            string test2 = "listen";
            if (CheckIfAnagram(test1, test2))
            {
                Console.WriteLine("Is Anagram");
            }

            else
            {
                Console.WriteLine("Not an Anagram");
            }
           
        }

        static bool CheckIfAnagram(string test1, string test2)
        {
            int[] alphaCount1 = new int[26];
            int[] alphaCount2 = new int[26];

            for (int i = 0; i < test1.Length; i++)
            {
                alphaCount1[test1[i] - 'a']++;
                alphaCount2[test2[i] - 'a']++;
            }

           

            for (int i = 0; i < 25; i++)
            {
                if (alphaCount1[i]!=alphaCount2[i])
                {
                    return false;
                }

            }

            return true;
        }
    }
}
