using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_01052016
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is practice with operators and order of precedence
            int a = (2 + 3) * 5;
            Console.WriteLine(a);

            int x;
            int y;
            x = y = 5 % 2 + 1;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            int x1 = 1 + 2 * 3;
            Console.WriteLine(x1++);  //the post fix operator adds one to the variable after it is printed
            Console.WriteLine(x1);

            int x2 = 1 + 2 * 3;
            Console.WriteLine("without parentheses: " + x2);
            x2 = 1 + (2 * 3);
            Console.WriteLine("with parentheses: " + x2);

            double y1 = 3.12 + 3.3 * 2.2;
            Console.WriteLine("without parentheses: " + y1);
            y1 = 3.12 + (3.3 * 2.2);
            Console.WriteLine("with parentheses: " + y1);
            Console.WriteLine();

            int x3 = 1;
            Console.WriteLine("x = " + x3);
            int y3 = x3++;
            Console.WriteLine("postfix operator used, y = " + y3);
            Console.WriteLine("x = " + x3);
            Console.WriteLine("y = "+ y3);

            bool lightSwitch = true;  //this means the light switch is on
            bool lamp = true;  //this means the lamp is on
            Console.WriteLine(lightSwitch && lamp);     //&& is true if both variables are true
            Console.WriteLine(lightSwitch || lamp);     //|| is true if one or both variables are true
            Console.WriteLine(!lightSwitch);            // ! is true if variable is not true
            Console.WriteLine(lightSwitch ^ lamp);      // ^ is true if only one variable is true
            Console.WriteLine();

            bool x10 = (1 != 2);
            Console.WriteLine(x10);
            Console.WriteLine();

            int x12 = 1;
            Console.WriteLine("x12 is assigned to: " + x12);
            x12 %= 3;
            Console.WriteLine("x12 was %= 3 and then x12 is assigned to: " + x12);

        }
    }
}
