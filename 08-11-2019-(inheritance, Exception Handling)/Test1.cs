using System;
using System.Exception;
class Test1
{
    public static void Main(string[] args)
    {
        int num = 100;
        int div = 0;
        try
        {
            num / div ;
        }
        catch (DividedByZeroException ex)
        {
            Console.WriteLine("The given number is dividing by the zero::");
        }
    }
}