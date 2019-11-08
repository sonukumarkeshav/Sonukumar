using System;
namespace OutParameter
{
    class Program
    {
        public void Show(out int val)
        {
            
            
          //  val = 20;
            Console.WriteLine("Value inside the Show function:" + val);
        }

        public static void Main(string[] agrs)
        {
            int val = 50;
            Program program = new Program();

            Console.WriteLine("Value before passing out variable " + val);
            program.Show(out val);
            Console.WriteLine("Value after receving the out variable " + val);
        }
    }
}