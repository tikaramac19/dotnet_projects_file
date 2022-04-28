// See https://aka.ms/new-console-template for more information

namespace Typecasting
{
    class program
    {
        public static void Main(string[] args)
        {

            typeCasting();
            // loopingStatement();
            // stringConcatinate();
            return;
        }

        public static void stringConcatinate(){
            //string concatination

            string fname = "Tikaram";
            string lname = "Acharya";

            string fullname = fname + " " + lname;

            Console.WriteLine(fullname);

            //string formating
            // var res1 = string.Format("{0} {1}");

            // Console.WriteLine(res1);

            // String interpolation

            var res2 = $" The reverse name order is:  {lname} {fname}";
            Console.WriteLine(res2);

            // to find out the length of the string 
            Console.WriteLine(res2.Length);

            // other useful methods
            // ToUpper() - convert to upper case
            Console.WriteLine(fname.ToUpper());
            // ToLower() - converts strings to the lower case

            Console.WriteLine(lname.ToLower());

        }
        public static void loopingStatement()
        {       
            //doing tasks repeatedly
            //initialization //condition //increament/Decrement

            //unknown quantities
            //while loop and do while loop

            Console.WriteLine("Enter a number ?");

            var num = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while(i<= 10)
            {
                Console.WriteLine(num + " * " + i + " = " + num * i);

                i++ ;

            }

            // do while loop

            // do{
            //      Console.WriteLine(num + " * " + i + " = " + num * i);

            //     i++ ;
            // }while(i<=10);

            // for each loop

            string[] days = new string[] {"sunday","monday", "tuesday" ,"wednesday", "thursday", "friday", "saturday"};

            foreach(var item in days)
            {
                if(item == "mondey"){
                    break;
                }
                Console.WriteLine("Day: "+ item);
            }
            
            
        }
        public static void typeCasting()
        {
                 Console.WriteLine("About TypeCasting !");

            //Type casting is when you assign va value of one data type to another type.

            // Implicit casting(automatically)
            // convertig a smaller type to a larger type size
            // char -> int -> long -> float -> double


            // Implicit casting is done automatically when passing a smaller size type to a larger size type

            int myInt = 22;

            double myDouble = myInt; // automatic casting : int to double

            Console.WriteLine(myInt); // output : 22
            Console.WriteLine(myDouble); // output : 22

            // Explicit casting
            // explicit casting must be done manually by placing the type in parentheses in front of the alue:
            double myDouble1 = 11.11;
            int myInt1 = (int) myDouble1;

            Console.WriteLine($"The int value is : {myInt1}"); // output : 11

        }
    }
}
