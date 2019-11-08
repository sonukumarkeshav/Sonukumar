using System;
namespace FunctionExample1
{
    class Program
    {
        public void Show(string message)
        {
            Console.WriteLine("Hello " + message);
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Show("Rahul Kumar");
        }
    }
}