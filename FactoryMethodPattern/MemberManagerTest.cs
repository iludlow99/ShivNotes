using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal sealed class MemberManagerTest : MemberManager
    {
        protected override EmailServiceBase MakeEmailService()
        {
            return new EmailServiceTest();
        }
    }
}
