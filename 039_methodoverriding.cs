using System;

namespace LearnCSharp
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");

        }
    }
        public class Dog: Animal
        {
            public override void eat()
            {
                Console.WriteLine("Eating braed...");
            }

        }
        public class TestMethodOverriding
        {
            public static void Main(string[] args)
            {
                Dog d = new Dog();
                d.eat();
            }
        }
    }

