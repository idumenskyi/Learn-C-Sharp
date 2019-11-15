using System;

namespace LearnCSharp
{
    public class Employee
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    class TestEmployee
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "Some Employee";
            Console.WriteLine("Employee Name: " + e1.Name);
        }
    }
    
}

