using System;

namespace Palidrome_Subseq
{
    class Program
    {
        static void Main(string[] args)
        {
            string palinCheck = "AsdA";
     
            if (CheckPalindrome(palinCheck))
            {
                Console.WriteLine("Is Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }

        private static bool CheckPalindrome(string palinCheck)
        {
            int length = palinCheck.Length - 1;
            int j = palinCheck.Length - 1;

            if (palinCheck.Length % 2 == 1)
            {
                for (int i = 0; i < length/2; i++)
            {
                
                    if(palinCheck[i]==palinCheck[j])
                    {
                        j--;
                        continue;
                    }

                    else 
                    {
                        return false;
                    }
                }

                return true;
            }

            else
            {
                for (int i = 0; i <= length / 2; i++)
                {

                    if (palinCheck[i] == palinCheck[j])
                    {
                        j--;
                        continue;
                    }

                    else
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
