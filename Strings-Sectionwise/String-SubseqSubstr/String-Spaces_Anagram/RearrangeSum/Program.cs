using System;

namespace RearrangeSum
{
    //Given a string containing uppercase alphabets and integer digits (from 0 to 9), 
    //the task is to print the alphabets in the order followed by the sum of digits.
    class Program
    {
        static void Main(string[] args)
        {
            RearrangString("AC2BEW3");
        }

        private static void RearrangString(string str)
        {
            int[] aplhaString = new int[26];
            int sum = 0;
            string output = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.ToUpper(str[i])>='A' && char.ToUpper(str[i])<='Z')
                {
                    aplhaString[str[i] - 'A']++;
                }

                else
                {
                    sum = sum + (str[i] - '0');
                }
            }

            for (int i = 0; i < aplhaString.Length; i++)
            {
                if (aplhaString[i]==1)
                {
                    output = output + (char)(i + 'A');
                }
                
            }
            Console.WriteLine(output+sum);
        }
    }
}
