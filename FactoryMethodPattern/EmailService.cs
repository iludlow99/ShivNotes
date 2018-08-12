using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class EmailService : EmailServiceBase
    {
        protected internal override void SendEmail()
        {
            Console.WriteLine("Email Sent");
        }
    }
}
