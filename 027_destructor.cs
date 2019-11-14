using System;

namespace LearnCSharp
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor invoked");
        }
        ~Employee()
        {
            Console.WriteLine("Destructor invoked");
        }

    }
    class SomeEmployee
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            

        }
    }
}
