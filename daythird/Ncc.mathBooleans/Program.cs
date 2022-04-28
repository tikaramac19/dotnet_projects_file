// See https://aka.ms/new-console-template for more information

using System;

namespace Ncc.mathBooleans
{
    class program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Working with inbuild math classes.");

            mathMethod();

            return;
            
        }
        public static void mathMethod()
        {
            // The c# Math class has many methods that allows you to perform mathematical tasks on numbers.

            //1. Math.Max(x,y)

            int a = 33;
            int b = 21;
            Console.WriteLine(Math.Max(a,b));

            // Taking input from the user 
            Console.WriteLine("Enter first number");
            int var1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int var2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The maximum number between two numbers is: ");
            Console.WriteLine($"{Math.Max(var1, var2)}");

            // 2. Math.Min(x,y)
            Console.WriteLine("The minimum number is : ");
            Console.WriteLine(Math.Min(var1, var2));

            // 3. Math.sqrt(x)
            Console.WriteLine("Square root of given number is : ");
            Console.WriteLine(Math.Sqrt(var1));
            Console.WriteLine(Math.Sqrt(var2));

            //4. Math.Abs(x)
            // it returns the absolute (positive ) value of x

            float x = (-23.66f);
            Console.WriteLine("Absolute value of given number is: ");
            Console.WriteLine(Math.Abs(x));

            //5. Math.Round()
            // it rounds a number to the nearest whole number.
            Console.WriteLine("ROund off value of given number is : ");
            Console.WriteLine(Math.Round(9.9999));



        }
    }
}