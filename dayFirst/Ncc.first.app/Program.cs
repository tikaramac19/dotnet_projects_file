// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        public static void Main()
        {
               Console.WriteLine("What is your name ?");

               var fullName = Console.ReadLine();
               var currentDate = DateTime.Now;

               Console.WriteLine($"{Environment.NewLine} Hello {fullName} on {currentDate:d} at {currentDate:t}");
               Console.WriteLine($"{Environment.NewLine} Press any key to exit...");
               Console.ReadKey(true);           
                                                                                
        }
    }
}
