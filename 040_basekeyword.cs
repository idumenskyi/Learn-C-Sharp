using System;

namespace LearnCSharp
{
    public class Animal
    {
        public string color = "white";
    }
        public class Dog: Animal
        {
            string color = "black";
            public void showColor()
            {
                Console.WriteLine(base.color);
                Console.WriteLine(color);
        }

        }
        public class TestMethodOverriding
        {
            public static void Main(string[] args)
            {
                Dog d = new Dog();
                d.showColor();
            }
        }
    }
