// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;

namespace Ncc.mathBooleans
{
    class program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Working with inbuild math classes.");

            // mathMethod();

            // aboutBoolean();

            aboutArray();

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

        public static void aboutBoolean()
        {
                Console.WriteLine("ABout Boolean ");
                // In programming, you will need a data type that can only have one of two values, like:
                // YES/NO
                // ON/OFF
                // TRUE/FALSE

                //for this , c# has a bool data type, which can take the values true or false.

                //Boolean Values

                bool isCsharpFun = true;
                bool isBuffTesty = false;  //Being a bahun i dont like this shit haha.

                Console.WriteLine(isBuffTesty);
                Console.WriteLine(isCsharpFun); 

                // Boolean Expression
                // A boolean expression is a c# expression that returns a boolean value: true or false;
                // You can use the comparasion operator, such as the greater than(>) operator to find of if an expression 
                // (or a variable) is true.

                int x = 10;
                int y = 6;

                Console.WriteLine(x>y); //true
                Console.WriteLine(y > x); // false

                // equal to operator to ealuate an expression

                int z = 22;
                Console.WriteLine(z ==22); //returns true

                Console.WriteLine(z == 21); //returns false
        }

        public static void aboutArray()
        {
            Console.WriteLine("About array !");
            // Arrays are used to store multiple values in a single variable, instead of declaring separate variable for each value.
            // To declare an array, define the variable type with square brackets.

            // string[] cars

            string[] cars = {"volvo", "Tesla", "ford", "BMW"};
            Console.WriteLine(cars[0]);

            //Access the elements of an array
            Console.WriteLine(cars[2]);

            //check length of an array
            Console.WriteLine(cars.Length);

            // to change an array
            cars[3] = "Tata";
            Console.WriteLine(cars[3]);

            // loop through an array
            //using forEach loop
            foreach(string item in cars){
                string items = item;
            Console.WriteLine(items);

            }

            //using for loop
             Console.WriteLine("Datas are : ");

            for(int i = 0 ; i< cars.Length ; i++)
            {
                string cardata = cars[i];
                Console.WriteLine(cardata);
            }

            // Sort Arrays
            //There are many arry methods available , for example sort(), which sorts an array alphabetically 
            //or in an ascending order

            // sort a string 
            
            string[] names = {"Tikaram", "anjal" , "manish", "ural" , "bibas"};

            Array.Sort(names);
            Console.WriteLine("The ascending order of given array values is: ");
            foreach(string item in names){
                Console.WriteLine(item);
            }

            // System.Linq Namespace

            //other useful array methods, such as Min, Max and Sum can be found in the system.linq namespace;

            int[] myNum = {5,2,7,9,4,6,1};

            Console.WriteLine(myNum.Max());
            Console.WriteLine(myNum.Min());
            Console.WriteLine(myNum.Sum());


            // Others ways to create an Array
            // we can also create array using new keyword.
            
            // create an array of five elements , and add values later
            string[] array1 = new string[5];

            // creates an array of four elements and add values righ away
            string[] array2 = new string[4] {"one","two" , "three" , "four"};


            // create an array of four elements without specifying the size
            // string array3 = new string[] {"one" , "two", "three", "four"};

            // create an array of four elements, omitting the new keyword, and without specifying the size.

            string[] array4 = {"One", "Two" ,"Three", "Four"};  

            // last option is faster and easier to read 
            //Note: If you declare an array and initialize it later, you have to use the new keyword.

            //declare an array
            int[] num1 ;

            // Add values , using new 
            num1 = new int[] {1,2,3,4,5};

        }
    }
}