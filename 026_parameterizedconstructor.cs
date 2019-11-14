using System;

namespace LearnCSharp
{


    public class Employee
    {
        public int id;
        public String name;
        public float salary;
        public Employee(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class SomeEmployee
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(100, "Some Employee1", 10000f);
            Employee e2 = new Employee(101, "Some Employee2", 15000f);
            e1.display();
            e2.display();

        }
    }
}
