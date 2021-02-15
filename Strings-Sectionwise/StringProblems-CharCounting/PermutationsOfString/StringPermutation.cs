using System;


namespace PermutationsOfString
{
   public class StringPermutation
    {
        public static void PrintStringPermutations(string permuteString, int low, int high)
        {
            if (low==high)
            {
                Console.WriteLine(permuteString);
            }

            else
            {
                for (int i = low; i <= high; i++)
                {
                    permuteString=  swap(permuteString, low, i);
                    PrintStringPermutations(permuteString, low+1, high);
                    permuteString = swap(permuteString, low, i);
                }
            }
        }

        private static string swap(string permuteString, int low, int i)
        {
            char temp;
            char[] charArray = permuteString.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[low];
            charArray[low] = temp;
            return new string(charArray);
        }
    }
}
