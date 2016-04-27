using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeVariables_01052016
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initializing all integer data types
            int thisIsInt = 20;  //uses 4 bytes and stores values roughly +/- 2 billion
            byte thisIsByte = 10;   //uses 1 byte and stores values 0 to 255
            short thisIsShort = 1234;  //uses 2 bytes and stores values about +/- 32000
            long thisIsLong = 12352523423;   //largest, uses 4 bytes and stores values to roughly +/- 9 quintillion!

            ushort thisIsUshort;
            uint thisIsUint;
            sbyte thisIsSbyte;
            ulong thisIsUlong;

            // Declaring and initializing all floating point data types
            float thisIsFloat = 3.14f;  //float is accurate to 7 decimal points.
            double thisIsDouble = 3.242345d;  //double is accurate to 15 decimal points.
            decimal thisIsDecimal = 3.141532255234m;   //decimal is the most accurate, use it for math.

            // Declaring and initializing boolean data type
            bool thisIsBoolean = true;

            // Declaring and initializing character data type
            char thisIsChar = 's';

            // Declaring and initializing string data type
            string thisIsString = "string";

            // This is a console application that will declare and assign 2 int variables and then print sum to the console.
            short firstNum;
            short secondNum;

            firstNum = 20;
            secondNum = 5;

            Console.WriteLine("This is the first number: " + firstNum);
            Console.WriteLine("This is the second number: " + secondNum);

            Console.Write("The sum of the first and second number is: ");
            Console.WriteLine(firstNum + secondNum);
        }
    }
}
