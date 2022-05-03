// See https://aka.ms/new-console-template for more information

using System;

namespace ObjectClass
{
    class Program
    {
        string books ;
        string mname ;
        // creating a class constructor with single parameter
        public Program(string middleName){ // passing parameter in constructor 
            books = "Bhagwat Geeta";

            mname = middleName;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("About class and object in c#");

            // Object -oriented programming has several advantages over procedural programming 
            // OOP is faster and easier to execute
            // OOP helps to keep the c# code DRY " dont repeat yourself", and makes the code easier to maintain, modify and debug
            // OOP provides a clear structure for the programs
            // OOP makes it possible to create full reusable applications with less code and shorter development time

            // Classes and objects are the two main aspects of object-oriented programming.
            // Class: fruits, objects: apple, banana, mango etc.
            // class: car,  objects: olvo , audi , toyota etc.

            // so , a class is a template for objects, and an object is an instance of a class.

            car myobj = new car();

            Console.WriteLine(myobj.color);

            Console.WriteLine(myobj.speed);

            Console.WriteLine(myobj.weight);

            // modifying the blank fields while creating objects
            myobj.fname = "Tikaram";
            myobj.lname = "Acharya";

            Console.WriteLine(myobj.fname);
            Console.WriteLine(myobj.lname);

            // object methods

            myobj.fullname(myobj.fname, myobj.lname);

            // Constructors
            // A constructor is a special method that is used to initialize objects. The advantage of 
            // a constructor is that it is called when an object of a class is created. It can be used to set
            // initial values for fields.

            // Create a Car class
            //class Car
            //{
            //public string model;  // Create a field

            // Create a class constructor for the Car class
            //public Car()
            //{
            //model = "Mustang"; // Set the initial value for model
            //}

            //static void Main(string[] args)
            //{
            // Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
            // Console.WriteLine(Ford.model);  // Print the value of model
            //}
            //}

            // Outputs "Mustang"

            // creating objecs of program class

            Program obj2 = new Program("Prasad");

            Console.WriteLine(obj2.books);

            //Note : Constructor name must match the class name, and it cannot have a return type (like void or int);
            // Constructor is called when the object is created 
            // All classes have constructors by default: if you do not create a class constructor yourself, 
            // C# creates one for you. However, then you are not able to set initial values for fields.
            // Constructors save time.

            // Constructor parameters
            // Constructors can also take parameters, which is used to initialize fields.

            Console.WriteLine(obj2.mname);

            // Note: You can have as many parameters as you want.

            // JUst like other methods, constructors can be overloaded by using different numbers of parameters.
        }


    }
}