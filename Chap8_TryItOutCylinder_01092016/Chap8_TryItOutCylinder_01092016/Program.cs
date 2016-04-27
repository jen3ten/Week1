using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap8_TryItOutCylinder_01092016
{
    class Program
    {
        static void Main(string[] args)
        {
            /* See page 48 of C# Players Guide
            Ask the user to enter a radius and height
            Calculate the volume and surface area of a cylind/er with the radius and height entered
            */

            // Provide introduction to the user
            Console.WriteLine("I will calculate the volume and surface area of a \ncylinder with the radius and height you enter.");
            Console.WriteLine();

            // Ask the user to enter a radius.  The variable is floating point and will accept a decimal answer.
            // Verify number is positive.  Verify number is <= 10.
            // Repeat to a maximum of 5 tries, then exit after 5 attempts
            Console.Write("Please enter the radius of the cylinder in inches (up to 10): ");
            double radius = double.Parse(Console.ReadLine());
            int triesRadius = 1;
            while (radius <= 0 || radius > 10)
            {
                Console.Write("Try Again!  \nPlease enter a radius greater than 0 and less than or equal to 10: ");
                radius = double.Parse(Console.ReadLine());
                triesRadius++;
                if (triesRadius == 5)
                {
                    Console.WriteLine("OK, let's say the radius is 3 inches.");
                    radius = 3;
                    break;
                }
            }
            Console.WriteLine();


            // Ask the user to enter a height.  The variable is a floating point and will accept a decimal answer.
            // Verify number is positive.  Verify number is <= 10.
            // Repeat to a maximum of 5 tries, then exit after 5 attempts
            Console.Write("Please enter the height of the cylinder in inches (up to 20): ");
            double height = double.Parse(Console.ReadLine());
            int triesHeight = 1;
            while (height <= 0 || height > 20)
            {
                Console.Write("Try Again!  \nPlease enter a height greater than 0 and less than or equal to 20: ");
                height = double.Parse(Console.ReadLine());
                triesHeight++;
                if (triesHeight == 5)
                {
                    Console.WriteLine("OK, let's say the height is 7.25 inches.");
                    height = 7.25;
                    break;
                }
            }
            Console.WriteLine();

            // The volume of a cylinder is Pi * r^2 * h, or Pi * radius * radius * height
            double volume = Math.PI * radius * radius * height;

            // Format the volume to output with 4 decimal points 
            Console.WriteLine(); 
            Console.WriteLine("The volume of the cylinder is {0:F2} cubic inches.", volume);

            // The surface area of a cylinder is 2 * Pi * r * (r + h), or 2 * Pi * radius * (radius + height)
            double surfaceArea = 2 * Math.PI * radius * (radius + height);

            // Format the surface area to output with 4 decimal points
            Console.WriteLine("The surface area of the cylinder is {0:F2} square inches.", surfaceArea);
            
        }
    }
}
