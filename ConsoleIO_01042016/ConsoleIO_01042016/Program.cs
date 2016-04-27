using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO_01042016
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            int x = 20;
            Console.WriteLine("Hello World");
            Console.WriteLine(x);
            x = 35;
            Console.WriteLine(x);
            Console.WriteLine(x % 35 == 0);
            Console.WriteLine((x % 5 == 0 && x % 7 == 0) ? "Yep" : "No " + x);
            Console.WriteLine((x - 20 <= 10) ? "Its less than or equal to 10. x = " + x : "Its not less than 10. x = " + x);
            */
            /*
            Console.WriteLine("We Can Code IT");
            Console.Write("Coding ");
            Console.Write("bootcamp");
            */
            /*
            Console.WriteLine("First name: ");
            string first_name = Console.ReadLine();

            Console.WriteLine("Last name: ");
            string last_name = Console.ReadLine();

            Console.WriteLine("The user's full name is " + first_name + " " + last_name + ".");

            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age as an integer = " + age);

            Console.WriteLine("Age: ");
            string age_string = Console.ReadLine();
            Console.WriteLine("Age as a string = " + age_string);
            */
            //Introduce the purpose of the program to the user
            Console.WriteLine("This is a program that asks for a user's information.");
            Console.WriteLine("Please enter your name, age, and gender as it is requested.");

            //Add a line return for readibility
            Console.WriteLine();

            //Request information from the user.  The user enters information on the same line as the question.
            //Inaccurate data will be accepted, such as an age that is not a number or gender not equal to male or female
            Console.Write("Your name <enter your name here>: ");
            string name = Console.ReadLine();
            Console.Write("Your age <enter your age here>: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Your gender <enter your gender here>: "); 
            string gender = Console.ReadLine();

            //Add a line return for readability
            Console.WriteLine();

            //Display the information back to the user and thank them for their time.
            Console.WriteLine("Your name is " + name+ " and you are " + age + " years old.");
            Console.WriteLine("You are a " + gender + ".");
            Console.WriteLine();
            Console.WriteLine("Thanks!");

        }
    }
}
