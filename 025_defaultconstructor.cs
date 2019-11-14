using System;

namespace LearnCSharp
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default Constructor");
        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();

        }
    }
}
