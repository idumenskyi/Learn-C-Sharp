using System;

namespace LearnCSharp
{
    public class FunctionWithParameterAndReturn
    {
        public string Show(string message)
        {
            Console.WriteLine("Inside show function");
            return message;
        }
        static void Main(string[] args)
        {
            FunctionWithParameterAndReturn FWPAR = new FunctionWithParameterAndReturn();
            string message = FWPAR.Show("someone");
            Console.WriteLine("Hello" + " " + message);
        }
    }
}
