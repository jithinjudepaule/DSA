using System;

namespace SearchArrayOfSortedStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] searchArray = new string[] {"for", "", "", "", "geeks",
                                                    "ide", "", "practice", "" ,
                                                    "", "quiz", "", ""};

            string searchString = "quiz";

            SearchString(searchArray, searchString,0,searchArray.Length-1);        
    }

        private static void SearchString(string[] searchArray, string searchString, int low, int high)
        {
            int mid = low + high / 2;
            int i = 0;

            while (searchArray[mid]!="")
            {
                mid--;
            }
           
            if (searchArray[mid]==searchString)
            {
                Console.WriteLine($"string found at index {mid}");
            }

            else if (searchString[i]<searchArray[mid][i] )
            {
                SearchString(searchArray, searchString, 0, mid - 1);
            }

            else if (searchString[i] > searchArray[mid][i])
            {
                SearchString(searchArray, searchString, mid+1,high);
            }
        }
    }
