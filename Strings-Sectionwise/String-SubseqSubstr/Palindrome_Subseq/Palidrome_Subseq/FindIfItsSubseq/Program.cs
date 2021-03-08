using System;

namespace FindIfItsSubseq
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "gksrek";
            string str2 = "geeksforgeeks";
            int m = str1.Length;
            int n = str2.Length;
            bool res = isSubSequence(str1, str2, m, n);

            if (res)
                Console.Write("Yes");
            else
                Console.Write("No");
        }

        static bool isSubSequence(string str1, string str2, int str1Length, int str2Length)
        {
            int j = 0;
            for (int i = 0; i < str2Length && j<str1Length; i++)
            {
                if (str1[j]==str2[i])
                {
                    j++;
                }
            }
            return (j == str1Length);

        }
    }
}
