using System;
using System.Collections.Generic;
using System.Linq;

namespace lowerCaseBetweenCapitals
{
    class Program
    {
        static void Main(string[] args)
        {
            FindAlphabets("edxedxxxCQiIVmiYEUtLi");
        }

        private static void FindAlphabets(string str)
        {
            int i = 0;
            int counter = 0;
            HashSet<char> uniqueChars = new HashSet<char>();
            HashSet<int> charCounthash = new HashSet<int>();
            for (; i < str.Length; i++)
            {
                if (str[i]>='a' && str[i]<='z')
                {
                    continue;
                }
                else
                {
                    i++;
                    break;
                }
            }

            for (; i < str.Length; i++)
            {
                if (str[i]>='A' && str[i]<='Z')
                {
                    counter = 0;
                }

                else
                {
                    while(i < str.Length && str[i]>='a'&&str[i]<='z'  )
                    {
                        if (!uniqueChars.Contains(str[i]))
                        {
                            uniqueChars.Add(str[i]);
                            counter++;
                        }
                        i++;
                    }
                    uniqueChars.Clear();
                    charCounthash.Add(counter);
                }
            }

            Console.WriteLine(charCounthash.Max());
        }
    }
}
