using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var memberManager = new MemberManager();
            memberManager.DoWork();
        }
    }
}
