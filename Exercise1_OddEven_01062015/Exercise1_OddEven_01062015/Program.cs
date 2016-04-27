using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_OddEven_01062015
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read integer input from console.  Determine if odd or even.  Return "odd" or "even" to the console.

            int number; // declares variable for input, as an integer
            string input;  // declares input variable as a string, to read input from the console
            string result; // declares variable for output, either "even" or "odd"
            int remainder; // declares variable to hold the remainder value; it will be 0 for even or 1 for odd

            Console.WriteLine("Please enter a number between 1 and 100 and I will tell you if it is odd or even: ");
            input = Console.ReadLine(); // read input from user
            number = int.Parse(input);  // convert the input to an integer so we can do math with it

            remainder = number % 2;
            result = (remainder == 0) ? "It is even!" : "It is odd!";
            Console.WriteLine(result);


             

        }
    }
}
