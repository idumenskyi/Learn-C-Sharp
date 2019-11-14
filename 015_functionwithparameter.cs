using System;

namespace LearnCSharp
{
    public class FunctionWithParameter
    {
        public void Show(string message)
        {
            Console.WriteLine("Hello" + " " + message);
        }
        static void Main(string[] args)
        {
            FunctionWithParameter FWP = new FunctionWithParameter();
            FWP.Show("someone");
        }
    }
}
