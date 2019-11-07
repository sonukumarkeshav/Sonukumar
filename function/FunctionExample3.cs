using System;
namespace FunctionExample
{
    class Program
    {
        public string Show(string name)
        {
            Console.WriteLine("Hello inside Show Fucntion" + name);
            return name;
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
           string name =  program.Show("Mohan");

           Console.WriteLine("Inside main Function " + name);
        }
    }
}