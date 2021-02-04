using System;
using System.Linq;


namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToCheckPangram = "The quick brown fox jumps over the lazy dog";
            CheckPangram(stringToCheckPangram);
        }

        private static void CheckPangram(string stringToCheckPangram)
        {
            bool[] alphabets = new bool[26];
            int index = 0;
            for (int i = 0; i < stringToCheckPangram.Length; i++)
            {
                if (stringToCheckPangram[i]>='A' && stringToCheckPangram[i]<='Z')
                {
                    index = stringToCheckPangram[i] - 'A';
                }
                else if (stringToCheckPangram[i] >= 'a' && stringToCheckPangram[i] <= 'z')
                {
                    index = stringToCheckPangram[i] - 'a';
                }
                alphabets[index] = true;
            }
            bool isPangram = true;
            for (int i = 0; i < alphabets.Length; i++)
            {

                if (alphabets[i]==false)
                {
                    isPangram = false;
                    break;
                }
            }
            if (isPangram)
            {
                Console.WriteLine("Its Pangram");
            }
            else
            {
                Console.WriteLine("Its not a  Pangram");
            }
        }
    }
}
