using System;
using System.Collections.Generic;
using System.Linq;

namespace PangrammaticLipogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "abc pqrstuv def wxyz ghi jkl mno";
           
            CheckForPangrammaticLipogram(testString);
        }

        static void CheckForPangrammaticLipogram(string testString)
        {
            bool[] alphabetsCheckArray = new bool[26];
            int index = 0;
            for (int i = 0; i < testString.Length; i++)
            {
                if (testString[i]>='A' && testString[i]<='Z')
                {
                    index = testString[i] - 'A';
                }

                if (testString[i] >= 'a' && testString[i] <= 'z')
                {
                    index = testString[i] - 'a';
                }

                alphabetsCheckArray[index] = true;
            }

            HashSet<char> hashset = new HashSet<char>();
            

            for (int i = 0; i < alphabetsCheckArray.Length; i++)
            {
                if (alphabetsCheckArray[i]==false)
                {
                    hashset.Add((char)('a'+i));
                    
                }
            }
            if (hashset.Count==0)
            {
                Console.WriteLine("Its a pangram");
            }

            else if (hashset.Count==1)
            {
                Console.WriteLine("Its a Lipogrammatic pangram");
            }

            else
            {
                Console.WriteLine("Its just a lipogram");
            }
            }
        }
    }

