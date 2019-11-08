using System;
public class Arrays5
{
    public static void Main(string[] args)
    {
        // Arrays declaration
        // Initialization of the array.
        // In the same line.
        int[][] arrays = new int[][]
        {
            new int[] {12, 23, 12, 6, 44, 34},
            new int[] {10, 11, 56, 89},
            new int[] {50, 45, 23, 12}
        };

        for(int i = 0 ; i < arrays.Length; i++)
        {
            for(int j = 0; j < arrays.Length; j++)
            {
                Console.WriteLine("Arrays elements == " +arrays[i][j]);
            }
        }
    }
}