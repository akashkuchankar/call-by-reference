using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Swap(ref a, ref b);
            Console.WriteLine($"a= {a} b={b}");
        }

    }
}
