// See https://aka.ms/new-console-template for more information

using System;

namespace Object
{ 
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("About Static and non-static class");

            // staticClass objOne = new staticClass();
            // This is not valid because staticClass itself a object
        }
    }

    public class NonStaticClass{
            public int i = 10;

        public void functionOne(){

            // public NonStaticClass(){

            // }

        }
        
    }
        //for static classs , all the members should be static like properties, methods , variables , 
        // constructor , distructor etc.
    public static class staticClass{
        // public void functionOne() is not allowed

        public static int i = 10;
        public static void functionOne(){

            // static staticClass(){
                
            // }
        }

    }
}