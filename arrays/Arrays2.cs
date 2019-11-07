using System;
class Arrays2
{
    public static void Main(string[] args)
    {
        string[] car = {"Volvo", "BMW", "Ford", "Mazda"};
        car[1] = "Maruti";
        for(int i = 0; i < car.Length; i++)
        {
            Console.WriteLine("The arrays elements at index [" + i + "] is ="+car[i]);
        }

    }
}