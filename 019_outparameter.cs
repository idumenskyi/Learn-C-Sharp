using System;

namespace LearnCSharp
{
    public class OutParameter
    {
        public void Show(out int num)
        {
            int square = 5;
            num = square;
            num *= num;
            Console.WriteLine("Inside show function" + " " + num);
            
        }
        static void Main(string[] args)
        {
            int num = 10;
            OutParameter OP = new OutParameter();
            Console.WriteLine("Before passing out variable" + " " + num);
            OP.Show(out num);
            Console.WriteLine("After recieving the out variable" + " " + num);
        }
    }
