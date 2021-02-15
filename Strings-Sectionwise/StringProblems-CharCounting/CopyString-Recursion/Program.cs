using System;
using System.Linq;

namespace CopyString_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringToCopy = "StringA".ToCharArray();
            var copiedString = "StringB".ToCharArray();
             CopyString(stringToCopy, copiedString,0);
        }

        static void CopyString( char[] stringToCopy,char[] copiedString,int index)
        {
            copiedString[index] = stringToCopy[index];
            if (index==stringToCopy.Length-1)
            {
                string copied = new string(copiedString);
                Console.WriteLine(copied);
                return;
            }
            CopyString(stringToCopy, copiedString, index + 1);

        }
    }
}
