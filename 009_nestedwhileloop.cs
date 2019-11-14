using System;

namespace LearnCSharp
{
    public class NestedWhileLoop
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 3)
            {
                int j = 1;
                while(j <= 3)
                {
                    Console.WriteLine(i + " " + j);
                    j++;
                }
                i++;
            }
        }
    }
}
