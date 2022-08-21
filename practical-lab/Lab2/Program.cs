namespace Ncc.Lab.two
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hello there, its lab 2");

            // creating object of class Introduction

            Introduction obj1 = new Introduction();

            obj1.FullName("Tikaram", "Acharya");

        }

        // creating class called introduction
        public class Introduction
        {
            public void FullName(string fname, string lname)
            {

                string fullname = fname + " " + lname;

                Console.WriteLine("My name is " + fullname + ".");

                // Single Inheritence
                SingleInheritence();

                // multiple inheritence

            }
        }

        static void SingleInheritence()
        {
            Console.WriteLine("About Single Inheritence !!");
            
            Cat c1 = new Cat();

            c1.Color();
            c1.Eat();
        }

        // multiple inheritence

        static void MultipleInheritence()
        {
            Console.WriteLine("About Multiple Inheritence");

            _Dog d1 = new _Dog();

            d1._breathe();
            d1._eat();
            d1._bark();
        }
    }

}
