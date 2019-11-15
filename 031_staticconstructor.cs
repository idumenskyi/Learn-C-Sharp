using System;

namespace LearnCSharp
{
    public class Account
    {
        public int accno;
        public String name;
        public static float rateOfInterest = 8.8f;
        public Account(int accno, String name)
        {
            this.accno = accno;
            this.name = name;

        }
        static Account()
        {
            rateOfInterest = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(accno + " " + name + " " + rateOfInterest);
        }
    }
    class SomeEmployee
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account(100, "Account1");
            Account a2 = new Account(101, "Account2");
            a1.display();
            a2.display();

        }
    }
}
