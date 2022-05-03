using System;

namespace ObjectClass
{
    public class car
    {
        // classes and objects
        // Everything in c# is associated with classes and objects, alogn with its attributes and methods.

        // TO create a class , use class keyword.
        // Eg: class Car {
        // string color = "red";
        // }

        // when a variable is declared directly in a class, it is often referred to as a field (or attribute).

        // create an object
        // An object is created from a class. We have already created the class named Car, so now we can use this to create objects.
        // To create an object of Car, specify the class name, followed by the object name, and use the keyword new.
        //         class Car 
        // {
        //   string color = "red";

        //   static void Main(string[] args)
        //   {
        //     Car myObj = new Car();
        //     Console.WriteLine(myObj.color);
        //   }
        // }

        public string color = "crimson";

        // Using Multiple Classes
        // You can also create an object of a class and access it in another class. 
        //This is often used for better organization of classes (one class has all the fields and methods
        // while the other class holds the Main() method (code to be executed)).

        // Here public keyword is an access modifier, which specifies that the color ariable/field
        // of car is accessible for other classes as well, such as Program

        // Class Members
        // Fields and methods inside classes are often referred to as "class members".
        // variables inside a class are called fields, and that we can access them by creating an 
        // object of the class, and by using the dot syntax (.)

        public int speed = 300;
        public int weight = 500;

        // We can also leave the fields blank, and modify them when creating the object.

        public string fname;  //fields
        public string lname;  // fields

        // This way is especially useful when creating multiple objects of one class
        //eg:
        // class Car
        // {
        //     string model;
        //     string color;
        //     int year;

        //     static void Main(string[] args)
        //     {
        //         Car Ford = new Car();
        //         Ford.model = "Mustang";
        //         Ford.color = "red";
        //         Ford.year = 1969;

        //         Car Opel = new Car();
        //         Opel.model = "Astra";
        //         Opel.color = "white";
        //         Opel.year = 2005;

        //         Console.WriteLine(Ford.model);
        //         Console.WriteLine(Opel.model);
        //     }
        // }

        // Object  Methods

        // Methods normally belogs to a class, and they define how an object of a class behaves.
        // Just like with fields, you can access methods with the dot syntax. 
        // Note that , the method must be public. and remember that we use the name of the method followed
        // by two parantheses () and a semicolon ; to call (execute) the method.

        public void fullname (string firstname, string lastname){
            Console.WriteLine(fname +" "+ lname);
        }

    }
}
