using System;

namespace LearnCSharp
{
    public class Array
    {
              
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            // int[] arr = new int[]{10, 20, 30, 40, 50};
            // int[] arr = new int[5]{10, 20, 30, 40, 50};
            // int[] arr = {10, 20, 30, 40, 50};
            arr[0] = 10;
            arr[2] = 20;
            arr[4] = 30;
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
