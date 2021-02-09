using System;

namespace AlphabetsInSamePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "abBeD";
            CheckIfAlphabetsAreInPlace(testString);
        }

        static void CheckIfAlphabetsAreInPlace(string testString)
        {
            int count = 0;

            for (int i = 0; i < testString.Length; i++)
            {
                var j =  2 - '0';
                if (i==(testString[i]-'a')|| i== testString[i]-'A')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
