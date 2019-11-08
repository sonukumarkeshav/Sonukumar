using System;
public class Arrays7
{
    public static void Main(string[] args)
    {
        // Jagged arrays and two- dimensional arrays
        // Multidimensionla arrays

        int[][,] arrays = new int[3][,];
        {
            new int[,] {{1,3},{5,7}},
            new int[,] {{0,2},{2,10}, {45, 56}},
            new int[,] {{11,33},{55,77},{32, 78} }
        };

        // Displaying the arrays

        for(int i = 0; i < arrays.Length; i++)
        {
            for(int j = 0; j < arrays.Length; j++)
            {
                Console.WriteLine("The arrays Elemetns ==  " +arrays[i][j]);
            }
        }
    }
}