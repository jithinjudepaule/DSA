using System;

namespace SearchSumInRotatedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 8, 9, 10, 1, 2, 3 };
            int sum = 13;

            if (findIfSumExists(array,sum))
            {
                Console.WriteLine("Sum exists");
            }

            else
            {
                Console.WriteLine("Sum does not exist");
            }
        }

        private static bool findIfSumExists(int[] array, int sum)
        {
            throw new NotImplementedException();
        }
    }
}
