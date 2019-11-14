using System;

namespace LearnCSharp
{
    public class NestedDoWhileLoop
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.WriteLine(i + " " + j);
                    j++;
                } while (j <= 3);
                i++;
            } while (i <= 3);
        }
    }
}
