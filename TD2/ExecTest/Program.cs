using System;

namespace ExeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
                Console.WriteLine("<HTML><BODY> Hello " + args[0] + " and " + args[1] + " from exe.</BODY></HTML>");
            else
                Console.WriteLine("ExeTest <string parameter>");
        }
    }
}
