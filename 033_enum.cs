using System;

namespace LearnCSharp
{
    public class Enums
    {
        public enum Season { WINTER, SPRING, SUMMER, FALL }

        public static void Main(string[] args)
        {
            int x = (int)Season.WINTER;
            int y = (int)Season.SUMMER;
            Console.WriteLine("WINTER = {0}", x);
            Console.WriteLine("SUMMER = {0}", y);
        }
    }
}

