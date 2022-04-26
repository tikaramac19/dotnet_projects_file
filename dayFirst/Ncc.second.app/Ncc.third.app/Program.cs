// See https://aka.ms/new-console-template for more information

namespace ConditionalStatement
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("If else concept: ");

            var num1 = 20;
            var num2 = 30;
            var num3 = 10;

            if(num1 >= num2 && num1 >= num3){
                Console.WriteLine("Num1 is greater than others");
            }
            else if(num2>= num1 && num2 >= num3){

                    Console.WriteLine("num2 is greater than others");
            }
            else{
                Console.WriteLine("num3 is greater than others");
            }

            ConditionalStatement();
            switchStatement();
            return;

        }
        static void ConditionalStatement ()
        {
            Console.WriteLine("Enter the day: ");
            var choice = Convert.ToInt32(Console.ReadLine());

            string day = "";

            if(choice == 1){
                day = "sunday";
            }
            else if(choice == 2){
                day = "mondey";
            }
            else if(choice == 3){
                day = "tuesday";
            }
            else if(choice ==4 ){
                day = "wednersday";
            }
            else if(choice ==5){
                day = "thursday";
            }
            else if(choice == 6){
                day ="friday";
            }
            else{
                day= "saturday";
            }

            Console.WriteLine(day);
        }
        static void switchStatement ()
        {   
            Console.WriteLine("Eneter the day: ");
            var choice1 = Convert.ToInt32(Console.ReadLine());
            string days = "";

            switch(choice1)
            {
               case 1:
                    days = "sunday";
                    break ;
                case 2:
                    days = "mondey";
                    break;
                case 3:
                    days = "Tuesday";
                    break;
                case 4:
                    days = "Tuesday";
                    break;
                case 5:
                    days = "Tuesday";
                    break;
                case 6:
                    days = "Tuesday";
                    break;
                case 7:
                    days = "Tuesday";
                    break;
                default:
                        days ="Invalid day";
                        break;

            }
            
            Console.WriteLine(days);

        }

    }
}