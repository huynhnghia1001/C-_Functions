using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_and_out_parameters
{
    internal class Program
    {
        static void TestFunc1(int args1)
        {
            args1 += 10;
            Console.WriteLine($"{args1}");
        }

        static void TestFunc2(ref int args1)
        {
            args1 += 10;
            Console.WriteLine($"{args1}");
        }

        static void PlusTimes(int arg1, int arg2, out int sum, out int product)
        {
            sum = arg1 + arg2;
            product = arg1 * arg2;
        }
        static void Main(string[] args)
        {
            int val1 = 10;
            int val2 = 20;

            TestFunc1(val1);
            Console.WriteLine($"{val1}");

            TestFunc2( ref val1);
            Console.WriteLine($"{val1}");

            int a, b;
            PlusTimes(val1, val2, out a, out b);
            Console.WriteLine($"{a}, {b}");
            Console.ReadKey();
        }
    }
}
