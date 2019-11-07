using System;
namespace CallByValue
{
    class Program
    {

        public void Show(int val)
        {
            val *= val;
            Console.WriteLine("Value inside the show function " +val);
        }
        public static void Main(string[] agrs)
        {
            int val = 50;
            Program program = new Program();
            Console.WriteLine("Value before calling   the function " + val);
            program.Show(val);
            Console.WriteLine("Value after calling the function :" + val);
        }
    }
}