using System;

namespace LearnCSharp
{
    public class Cal
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    public class TestMethodOverloading
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Cal.add(5, 6));
            Console.WriteLine(Cal.add(5, 6, 7));
        }
    }
}

