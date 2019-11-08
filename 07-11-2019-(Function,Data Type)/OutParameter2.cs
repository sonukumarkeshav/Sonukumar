using System;
namespace OutParameter2
{
    class Program
    {
        public void Show(out int a, out int b)
        {
            int square = 5;
            a = square;
            b = square;

            a *= a;
            b *= b;
        }


    public static void Main(string[] agrs)
        {
            int val1 = 50, val2 = 100;
            Program program = new Program();
            Console.WriteLine("Value before passing \n val1= " +val1+ "\n val2 = " +val2);
            program.Show(out val1, out val2);
            Console.WriteLine("Value after passing \n val1 = "+ val1 + "\n val2 " +val2);
        }


    }
}