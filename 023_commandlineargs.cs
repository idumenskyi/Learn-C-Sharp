using System;

namespace LearnCSharp
{
    class CommandLineArgs
    {
              
        static void Main(string[] args)
        {
            Console.WriteLine("Argument length: " + args.Length);
            Console.WriteLine("Supplied Arguments are: ");
            foreach(Object obj in args)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
