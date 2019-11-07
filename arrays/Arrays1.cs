using System;
class Arrays1
{
    public static void Main(string[] args)
    {
        string[] car = {"Volvo", "BMW", "Ford", "Mazda"};

        for(int i = 0; i < car.Length;i++)
        {
            Console.WriteLine("Arrays  elements at [" +i+"]  index  =" + car[i]);
        }
    }
}