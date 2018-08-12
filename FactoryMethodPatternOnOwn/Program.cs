using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternOnOwn
{
    class Program
    {
        static void Main(string[] args)
        {
            var theater = new TheaterTest();
            theater.ShowMovie();

            Console.ReadLine();
        }
    }
}
