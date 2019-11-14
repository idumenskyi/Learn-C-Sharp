using System;

namespace LearnCSharp
{
    public class IfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("It is even number");
            }
            else
            {
                Console.WriteLine("It is odd number");
            }
            
        }
    }
}
