// See https://aka.ms/new-console-template for more information

namespace Typecasting
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("About TypeCasting !");

            //Type casting is when you assign va value of one data type to another type.

            // Implicit casting(automatically)
            // convertig a smaller type to a larger type size


            // loopingStatement();
            stringConcatinate();
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
    }
}
