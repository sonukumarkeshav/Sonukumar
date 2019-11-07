using System;
public class Arrays6
{
    public static void Main(string[] args)
    {
        // Arrays declaration
        // Arrays initialaztion on the same line without used of the new operators
        int[][] arrays = 
        {
            new int[] {11, 34, 22, 78, 34},
            new int[] {90, 45, 34, 767},
            new int[] {80, 23, 12, 67,23}
        };

        // Displaying the elements of the arrays 

        for(int i = 0; i < arrays.Length; i++)
        {
            for(int j = 0; j < arrays.Length; j++)
            {
                Console.WriteLine("Arrays Elements == " +arrays[i][j]);
            }
        }
    }
}