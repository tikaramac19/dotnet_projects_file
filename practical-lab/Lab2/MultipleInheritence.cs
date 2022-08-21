
namespace Ncc.Lab.two
{
    public class _LivingThings
    {
        public void _breathe()
        {
            Console.WriteLine("Living Things can breathe");
        }
    }
    public class _Animal : _LivingThings
    {
        public void _eat() { Console.WriteLine("Animal can eat"); }
    }
    public class _Dog : _Animal
    {
        public void _bark() { Console.WriteLine("Dog can bark"); }
    }
}