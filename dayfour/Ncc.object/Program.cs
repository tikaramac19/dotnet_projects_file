// See https://aka.ms/new-console-template for more information

using System;

namespace Object
{ 
    class Program
    {
        public static void Main(string[] args)
        {
           

            Car ob1 = new Car(); // creating object of the class Car
            Car ob2 = new Car();

            Car Ford = new Car();
                Ford.model = "Mustang";
                Ford.color = "Green";
                Ford.year = 1999;

            Car opel = new Car();
                opel.model = "Astra";
                opel.color = "red";
                opel.year = 2015;

            Console.WriteLine(Ford.model);
            Console.WriteLine(opel.model);

            // Console.WriteLine(ob1.color);
            // Console.WriteLine(ob2.color);

            ClassMem obj3 = new ClassMem();

            obj3.inform();
            Console.WriteLine(obj3.maxSpeed);
            
            // working with constructor

            FullName name = new FullName("prasad");

            Console.WriteLine($"my name is {name.fname} {name.lname}.");
          
        }
    }

   
}