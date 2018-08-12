using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal sealed class EmailServiceTest : EmailServiceBase
    {
        protected internal override void SendEmail()
        {
            Console.WriteLine("Test email, no email was sent");
        }
    }
}
