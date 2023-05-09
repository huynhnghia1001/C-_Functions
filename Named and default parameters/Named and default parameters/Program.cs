using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_and_default_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PrintWithPrefix(string thestr, string prefix="")
            {
                Console.WriteLine($"{prefix}{thestr}");
            }
            PrintWithPrefix("Hello There!");
            PrintWithPrefix("Hello There!", ">:");
            PrintWithPrefix(prefix: "%", thestr: "Hello There!");
            Console.ReadKey();
        }
    }
}
