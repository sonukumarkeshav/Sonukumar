using System;
class Arrays4
{
    public static void Main(String[] args)
    {
        // Arrays declaration
        int[][] arrays = new int[3][];

        // Before used the arrays we have to initialized its.
        // Initialization of the array.

        arrays[0] = new int[5]{1, 3, 5, 7, 9};
        arrays[1] = new int[4]{0, 2, 4, 6};
        arrays[2] = new int[2]{11, 22};
        
        
            

        // Showing the all elemetns of the arrays

        for(int i = 0; i < arrays.Length; i++)
        {
            for(int j = 0; j < arrays.Length; j++)
            {
                Console.WriteLine("Elements of the array at index  "+ i + " = "+arrays[i][j]);
            }
        }


    }
}