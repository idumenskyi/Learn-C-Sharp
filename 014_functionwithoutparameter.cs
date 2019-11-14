using System;

namespace LearnCSharp
{
    public class FunctionWithoutParameter
    {
        public void Show()
        {
            Console.WriteLine("Function call without parameter");
        }
        static void Main(string[] args)
        {
            FunctionWithoutParameter FWP = new FunctionWithoutParameter();
            FWP.Show();
        }
    }
}
