using System;

namespace SameCharInWord
{
    class Program
    {
        private static bool isSame=true;

        static void Main(string[] args)
        {
            string testString = "abdabc";
            CheckIfCharsAreSame(testString);
           
        }

        private static void CheckIfCharsAreSame(string testString)
        {
            int[] half1 = new int[26];
            int[] half2 = new int[26];
            int half1EndIndex;
            int half2StartIndex;
            if (testString.Length%2==0)
            {
                half1EndIndex = (testString.Length - 1) / 2;
                half2StartIndex = half1EndIndex + 1;
            }
            else
            {
                half1EndIndex = ((testString.Length - 1) / 2) - 1;
                half2StartIndex = half1EndIndex + 2;
            }

            for (int i = 0; i <= half1EndIndex; i++)
            {
                half1[testString[i] - 'a']++;
            }

            for (int i = half2StartIndex; i < testString.Length; i++)
            {
                half2[testString[i] - 'a']++;
            }
            for (int i = 0; i < half1.Length; i++)
            {
                if (half1[i] != half2[i])
                {
                    isSame = false;
                    break;
                }
            }
            if (isSame)
            {
                Console.WriteLine("Is same");
            }

            else
            {
                Console.WriteLine("Not same");
            }
           

        }
    }
}
