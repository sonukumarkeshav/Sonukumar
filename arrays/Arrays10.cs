using System;
public class Arrays10
{
    public static void Main(string[] args)
    {
        int[,] arrays = new int[3,2] {{2,22},{3, 33},{5, 55}};
        foreach(int i in arrays)
        {
            Console.Write("{0} ", i);
        }
    }
}
