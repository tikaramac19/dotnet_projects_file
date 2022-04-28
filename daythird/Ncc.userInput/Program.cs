// See https://aka.ms/new-console-template for more information

using System;

namespace Ncc.userInput
{
    class program
    {
        public static void Main()
        {
            Console.WriteLine("lets learn details about user Input ! ");

            userInput();

            return;
        }
        public static void userInput()
        {
                //get user input

                // we have already learned that Console.WriteLine()is used to print values. 
                // Now we will use Console.ReadLine() to get user input.

                //example

                Console.WriteLine("Enter your First Name : "); // type your first name and press enter

                // creates a string variable and get user input from the keyboard and store it in the variable.
                string fname = Console.ReadLine();

                // Console.WriteLine($"{Environment.NewLine}");

                Console.WriteLine("Enter your Last Name: ");

                string lname = Console.ReadLine();

                // Console.WriteLine($"{Environment.NewLine}");

                string fullname = fname + " " + lname;
                Console.WriteLine($"Your fullname is :{fullname}");

            // User input and Numbers
            
            // The Console.ReadLine() method returns a string. 
            //Therefore, we cannot get information from another data types, such as int.
            //the following example shows an error

/*
            Console.WriteLine("Enter your age : ");
            int age = Console.ReadLine(); // This is invalid

            Console.WriteLine("The age is " + age);
*/

            // Like the error says, we cannot implicity convert type 'string' to 'int'.

            //solution

            Console.WriteLine("Enter your age : ");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your age is : {age}");
        }
    }
}