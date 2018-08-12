using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivNotes
{
    class Program
    {
        private static void Main(string[] args)
        {
            var singleton = MySingleton.CreateSingleton();
        }

        internal class MySingleton
        {
            private static MySingleton _instance;

            private MySingleton()
            {
                
            }

            public static MySingleton CreateSingleton()
            {
                return _instance;
            }
        }
    }
}
