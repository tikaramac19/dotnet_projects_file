// See https://aka.ms/new-console-template for more information


namespace DataTypes
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("About dataTypes and variables");

            // variables

            int a = 80;
            int b = 80;
            int sum = a + b;
            Console.WriteLine(sum);

            string fname = "Tikaram ";
            string lname = "Acharya";
            string fullname = (fname + lname);
            Console.WriteLine(fullname);

            // taking input from the user

            Console.WriteLine("Enter the first word: ");
            string c = Console.ReadLine();

            Console.WriteLine("ENter the second word: ");
            string d = Console.ReadLine();

            string addition = (c + " " + d);

            Console.WriteLine($"{Environment.NewLine} {addition}");

            Console.WriteLine($"{Environment.NewLine} press any key to exit...");

            Console.ReadKey(true);

            // DataTypes

            // int myNum = 5;               // Integer (whole number)
            // double myDoubleNum = 5.99D;  // Floating point number
            // char myLetter = 'D';         // Character
            // bool myBool = true;          // Boolean
            // string myText = "Hello";     // String

            // long
            // This is used when int is not large enough to store the value. Note that you should end the value with an "L"

            long mynum = 1500000000L;
            Console.WriteLine(mynum);

            // FLoating point types
            //End the value with an 'F'

            float myfloat = 3.14159f;
            Console.WriteLine(myfloat);

            // Scientific Numbers
            // A floating point number can also be a scientific number with and "e" to indicated the power of 10.

            float f1 = 35e3F;
            double f2 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(f2);

            //Booleanns types
            // A boolean data type is declared with the bool keyword and can only take the values true or false.

            bool istrue = true;
            bool isfalse = false;
            Console.WriteLine(istrue);
            Console.WriteLine(isfalse);

        }
    }
}