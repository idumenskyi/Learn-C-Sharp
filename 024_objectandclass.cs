using System;

namespace LearnCSharp
{
    public class Student
    {
        int id;
        String name;
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.id = 50;
            s1.name = "Some Student";
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);

        }
    }
}
