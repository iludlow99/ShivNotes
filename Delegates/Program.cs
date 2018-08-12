using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate a, b, c, d;
            a = new MyDelegate(Method1);
            b = Method2;
            c = a + b;
            c("Isaac");
            c -= a;
            c("Isaac");
        }

        static void Method1(string data)
        {
            Console.WriteLine("Method1: " + data);
        }

        static void Method2(string data)
        {
            Console.WriteLine("Method2: " + data);
        }

        delegate void MyDelegate(string data);
    }
}
