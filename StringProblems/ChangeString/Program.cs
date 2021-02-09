using System;

namespace ChangeString
{
    //Given a 26 letter character set, which is equivalent to character set of English alphabet//i.e. (abcd….xyz) and act as a relation. 
    //We are also given several sentences and we have to translate them with the help of given new character set.
    class Program
    {
        static void Main(string[] args)
        {
            string characterset = "qwertyuiopasdfghjklzxcvbnm";
            string testString = "utta";
            TranslateCharacters(characterset, testString); 
            TranslateCharactersUsingHashing(characterset, testString);


        }

        

        static void TranslateCharacters(string characterset, string testString)
        {
            string convertedString = "";
            char[] alphabets = "abcdefghijklmopqrstuvwxyz".ToCharArray();
            foreach (var testChar in testString.ToCharArray())
            {
                convertedString = convertedString + alphabets[characterset.IndexOf(testChar)];
            }
            Console.WriteLine(convertedString);
        }

        private static void TranslateCharactersUsingHashing(string characterset, string testString)
        {
            int n = testString.Length;
            char[] charSet = characterset.ToCharArray();
            // hashing for new character set 
            char[] hashChar = new char[26];
            for (int i = 0; i < 26; i++)
            {
                hashChar[Math.Abs(charSet[i] - 'a')] = (char)('a' + i);
            }

            // conversion of new character set 
            String s = "";
            for (int i = 0; i < n; i++)
            {
                s += hashChar[testString[i] - 'a'];
            }
        }
    }
}
