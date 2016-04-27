using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_01062016
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code tests whether casting from double to int will round or truncate the value
            double myDouble = 3.9;
            int myInt = (int)myDouble;
            Console.WriteLine(myInt);
            Console.WriteLine();

            // This code tests using as int to cast;  It did not work
            //double myDouble1 = 3.9;
            //int myInt1 = myDouble1 as int;
            //Console.WriteLine(myInt1);

            // An example of implicit conversion
            int x2 = 5;
            long y2 = x2;
            Console.WriteLine(x2);
            Console.WriteLine(y2);
            Console.WriteLine();

            // An example of explicit conversion
            double num3 = 3.14;
            long y3 = (long)num3;
            int x3 = (int)y3;

            // Implicit conversion did not work.  Cast is needed.
            //long y3 = num3;
            //int x3 = y3;

            Console.WriteLine("Num3 = "+ num3);
            Console.WriteLine("y3 = " + y3);
            Console.WriteLine("x3 = " + x3);
            Console.WriteLine();





        }
    }
}
