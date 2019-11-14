using System;

namespace LearnCSharp
{
    public class MultiArray
    {
              
        static void Main(string[] args)
        {
            int[,] arr = new int[3,3];
            // int[,] arr = new int[3, 3] = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            // int[,] arr = new int[,]{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            // int[,] arr = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            // int[,,] arr = new int[3, 3, 3];
            arr[0,1] = 10;
            arr[1,2] = 20;
            arr[2,0] = 30;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
