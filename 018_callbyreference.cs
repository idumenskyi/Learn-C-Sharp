using System;

namespace LearnCSharp
{
    public class CallByRefrence
    {
        public void Show(ref int num)
        {
            num *= num;
            Console.WriteLine("Inside show function" + " " + num);
            
        }
        static void Main(string[] args)
        {
            int num = 10;
            CallByRefrence CBR = new CallByRefrence();
            Console.WriteLine("Before calling the function" + " " + num);
            CBR.Show(ref num);
            Console.WriteLine("After calling the function" + " " + num);
        }
    }
}
