using System;

namespace foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var env = args.Length > 0 ? args[0] : String.Empty;
            var runner = args.Length > 1 ? args[1] : String.Empty;

            Console.Writeline(env);
            Console.Writeline(runner);
            

        }
    }
}
