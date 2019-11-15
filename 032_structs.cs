using System;

namespace LearnCSharp
{
    public struct Rectangle
    {
        public int width, height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public void areaOfRectangle()
        {
            Console.WriteLine("Area of Rectangle is: " + (width * height));
        }
    }
    public class TestStructs
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 6);
            r.areaOfRectangle();
        }
    }
}
