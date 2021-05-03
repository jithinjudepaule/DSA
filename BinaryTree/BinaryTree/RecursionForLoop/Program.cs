using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial(4);
        }

        static int Factorial(int number)
        {
            // Declare a temporary variable of type integer
            int temp;

            // This is a guard clause that returns from the function immediately
            // if the value of the argument is less than or equal to 1.
            // In that case, it simply returns a value of 1.
            // (This is important to prevent the function from recursively calling itself
            // forever, producing an infinite loop!)
            if (number <= 1) return 1;

            // Set the value of the temp variable equal to the value of the argument
            // multiplied by a recursive call to the Factorial function
            temp = number * Factorial(number - 1);

            // Return the value of the temporary variable
            return temp;
        }
    }
}
