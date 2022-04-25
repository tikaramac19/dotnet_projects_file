// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        public static void Main()
        {
                Console.WriteLine("What is your name?");

                var fullname = Console.ReadLine();
                var currentDate = DateTime.Now;
                Console.WriteLine($"{Environment.NewLine} Hello,  {fullname}, on {currentDate} at {currentDate}");
                Console.Write($"{Environment.NewLine} press any key to exit...");
                Console.ReadKey(true);            
                                                                                
        }
    }
}
