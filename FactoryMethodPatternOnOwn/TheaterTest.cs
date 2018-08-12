using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatternOnOwn
{
    internal sealed class TheaterTest : Theater
    {
        protected internal override MovieBase LoadMovie()
        {
            return new MovieTest();
        }
    }
}
