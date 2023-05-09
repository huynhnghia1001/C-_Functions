using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float MilesToKm(float miles)
            {
                float result = miles * 1.6f;
                return result;
            }

            Console.WriteLine($"The result is {MilesToKm(8.0f)}");
            Console.WriteLine($"The result is {MilesToKm(52.0f)}");

            void PrintWithPrefix(string theStr)
            {
                Console.WriteLine($"::> {theStr}");
            }

            PrintWithPrefix("Test String");
            PrintWithPrefix("Another Test String");

            Console.ReadKey();
        }
    }
}
