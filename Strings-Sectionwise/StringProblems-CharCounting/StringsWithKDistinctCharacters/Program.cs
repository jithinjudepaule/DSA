using System;

namespace StringsWithKDistinctCharacters
{
   // String with k distinct characters and no same characters adjacent
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int k = 3;
            FindDistinctCharacters(n, k);
        }

        private static void FindDistinctCharacters(int n, int k)
        {

            int count = 0;
            char[] alphabetArray = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int i = 0; i < n; i++)
            {
                if (k!=count)
                {
                    Console.WriteLine(alphabetArray[i]);
                    count++;
                }
                else if (k==count)
                {
                    Console.WriteLine(alphabetArray[n-i-1]);
                }
            }
        }
    }
}
