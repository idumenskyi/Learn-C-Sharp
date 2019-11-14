using System;

namespace LearnCSharp
{
    public class GotoStatement
    {
        static void Main(string[] args)
        {
        ineligible:
            Console.WriteLine("You are not eligible");
            Console.WriteLine("Enter your age:\n");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You are eligible to vote!");
            }
        }
    }
}
