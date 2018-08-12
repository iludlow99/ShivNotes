using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternOnOwn
{
    internal sealed class AntMan : MovieBase
    {
        public override void Play()
        {
            Console.WriteLine("Playing Ant Man");
        }
    }
}
