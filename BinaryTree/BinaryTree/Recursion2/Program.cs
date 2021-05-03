using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion2
{
    class Program
    {
        static void Main(string[] args)
        {
            fun2(2);
        }

       static void fun2(int n)
        {
            if (n == 0)
                return;

            fun2(n / 2);
            Console.Write(n % 2);
            fun2(n + 20);
        }
        // This code is contributed by shubhamsingh10

    }
}
