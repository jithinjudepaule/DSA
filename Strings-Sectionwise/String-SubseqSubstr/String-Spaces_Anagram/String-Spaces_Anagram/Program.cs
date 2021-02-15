using System;
using System.Collections.Generic;

namespace String_Spaces_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Hello World";
            ReplaceCapitals(testString);
        }

        static void ReplaceCapitals(string testString)
        {
            List<char> stringWithSpaces = new List<char>();

            if (testString[0] >= 'A' && testString[0] <= 'Z')
            {
                char capitals = (char)((int)(testString[0]) + ('a' - 'A'));
                stringWithSpaces.Add(capitals);
            }
            for (int i = 1; i < testString.Length; i++)
            {
                if (testString[i]>='A' && testString[i]<='Z')
                {
                    char capitals = (char)((int)(testString[i]) + ('a' - 'A')); 
                    stringWithSpaces.Add(' ');
                    stringWithSpaces.Add(capitals);
                }
                else
                {
                    stringWithSpaces.Add(testString[i]);
                }
            }
            Console.WriteLine(new string(stringWithSpaces.ToArray()));
        }
    }
}
