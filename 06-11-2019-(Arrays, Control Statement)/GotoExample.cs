using System;
public class GotoExample
{
    public static void Main(String[] args)
    {
        ineligible:
            Console.WriteLine("you are not eligible to vote:");

        Console.WriteLine("enter your age : \n");
        int age = Convert.ToInt32(Console.ReadLine());

        if(age > 18 )
        {
            goto ineligible;
        }
        else
        {
            Console.WriteLine("you are eligible for vote :");
        }
    }
}