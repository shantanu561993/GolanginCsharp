using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GolangInSharp
{
    class Program
    {
        [DllImport("main", EntryPoint = "PrintHello")]
        extern static void PrintHello();

        [DllImport("main", EntryPoint = "Sum")]
        extern static int Sum(int a, int b);

        [DllImport("main", EntryPoint = "stringtest")]
        extern static int stringtest(byte[] test);

        static void Main(string[] args)
        {
            PrintHello();
            int c = Sum(3, 5);
            Console.WriteLine("Call Go Func to Add 3 and 5, result is " + c);
            stringtest(Encoding.ASCII.GetBytes("I Am String"));
            Console.ReadKey();
        }
    }
}
