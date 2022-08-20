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


    }

    // creating class called introduction
    public class Introduction
    {
        public  void FullName(string fname, string lname)
        {

            string fullname = fname + " " + lname;

            Console.WriteLine("My name is " + fullname + ".");
        }
    }

}
