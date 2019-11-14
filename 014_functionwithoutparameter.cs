using System;

namespace LearnCSharp
{
    public class FunctionWithoutStatement
    {
        public void Show()
        {
            Console.WriteLine("Function call without parameter");
        }
        static void Main(string[] args)
        {
            FunctionWithoutStatement FWS = new FunctionWithoutStatement();
            FWS.Show();
        }
    }
}
