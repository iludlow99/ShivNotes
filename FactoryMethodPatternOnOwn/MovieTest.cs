using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternOnOwn
{
    internal class MovieTest : MovieBase
    {
        public override void Play()
        {
            Console.WriteLine("Playing test movie");
        }
    }
}
