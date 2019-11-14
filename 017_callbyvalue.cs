using System;

namespace LearnCSharp
{
    public class CallByValue
    {
        public void Show(int num)
        {
            num *= num;
            Console.WriteLine("Inside show function" + " " + num);
            
        }
        static void Main(string[] args)
        {
            int num = 10;
            CallByValue CBV = new CallByValue();
            Console.WriteLine("Before calling the function" + " " + num);
            CBV.Show(num);
            Console.WriteLine("After calling the function" + " " + num);
        }
    }
}
