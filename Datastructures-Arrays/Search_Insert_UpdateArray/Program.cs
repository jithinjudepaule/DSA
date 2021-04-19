using System;

namespace Search_Insert_UpdateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 4, 1, 0, 6 };

            bool isSearchFound = searchEle(array,1);
            bool isInsertSuccesful = insertEle(array, 2,2);
            bool isDeleteSuccessful = deleteEle(array, 2);
        }
        static bool searchEle(int []a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (x == a[i])
                {
                    return true;
                }
            }
            return false;
        }
        static bool insertEle(int[] a, int y, int yi)
        {
            // add code here.
            a[yi] = y;
            return true;
        }
        static bool deleteEle(int[] a, int z)
        {
            bool flag = false;
            int[] deletedArray = new int[a.Length-1];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                
                if (a[i]==z)
                {
                    deletedArray[j] = a[i + 1];
                    i++;
                }
                else
                {
                    deletedArray[j] = a[i];
                }
                j++;
            }
            return flag;
        }
    }
}
