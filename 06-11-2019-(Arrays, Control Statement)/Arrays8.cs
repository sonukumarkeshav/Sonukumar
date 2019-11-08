using System;
public class Arrays8
{
    public static void Main(string[] args)
    {
        // declared the arrays
        int[][] arrays = new int[2][];
        
        // initilazation the arrays
        arrays[0] = new int[5] {2,5,3,8,9};
        arrays[1] = new int[3] {5,7,3};


        // Displaying the arrays
        for(int i = 0; i < arrays.Length; i++)
        {
            Console.Write("Elements({0}):", i);

            for(int j = 0; j < arrays.Length; j++)
            {
                Console.Write("{0}{1}", arrays[i][j], j == (arrays[i].Length - 1)  ? "" :"" );
            }
            Console.WriteLine();
        }
        Console.WriteLine("Press any key to exit ::");
        Console.ReadKey();
    }
}