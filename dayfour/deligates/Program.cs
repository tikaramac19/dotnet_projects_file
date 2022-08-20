// See https://aka.ms/new-console-template for more information

using System;

namespace deligates 
{
     class program
    {
        public static void Main()
        {
            Console.WriteLine("Hello there");

            Console.WriteLine("stack container");

            customStackImplementation();
        }
        

        public static void customStackImplementation(){
                customStack cs = new customStack();

                cs.push(12);
                cs.push(22);
                cs.push(11);
                cs.push(33);

                cs.pop();
        }
    }
}
