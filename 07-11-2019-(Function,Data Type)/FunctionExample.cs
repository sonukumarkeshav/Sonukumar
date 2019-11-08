using System;
namespace FunctionExample
{
    class Program
    {
        public void Show()
        {
            Console.WriteLine("This is not parametrized function: ");
        }
        public static void Main(String[] args)
        {
            Program program = new Program();
            program.Show();
        }
    }
}