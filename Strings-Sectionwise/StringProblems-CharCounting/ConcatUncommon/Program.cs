using System;

namespace ConcatUncommon
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "abcs";
            string string2 = "cxzca";
            ConcatenateUncommon(string1, string2);
        }

        private static void ConcatenateUncommon(string string1, string string2)
        {
            int[] alphabets = new int[26];
            for (int i = 0; i < string1.Length; i++)
            {
                alphabets[string1[i] - 'a'] = 1;
            }

            for (int i = 0; i < string2.Length; i++)
            {
                if (alphabets[string2[i] - 'a'] == 1 || alphabets[string2[i] - 'a'] == -1)
                {
                    alphabets[string2[i] - 'a'] = -1;
                }

                else
                {
                    alphabets[string2[i] - 'a'] = 2;
                }
                
            }
            string concat = "";
            for (int i = 0; i < alphabets.Length; i++)
            {

                if (alphabets[i]==1 || alphabets[i] == 2)
                {
                    Console.WriteLine((char)(i + 'a')); ;
                }


            }
        }
    }
}
