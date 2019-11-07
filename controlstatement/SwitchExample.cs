using System;
public class SwitchExample
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        switch(num)
        {
            case 10: 
                Console.WriteLine("Its is 10 :");
                break;
            case 20:
                Console.WriteLine("Its is 20:");
                break;
            case 30:
                Console.WriteLine("Its is 30");
                break;
             default:
                 Console.WriteLine("i=Its not 10, 20, 30");
                break;
        }
    }
}