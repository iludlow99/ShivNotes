using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class MemberManager
    {
        protected virtual EmailServiceBase MakeEmailService()
        {
            return new EmailService();
        }

        public void DoWork()
        {
            DoStep1();
            DoStep2();
            var emailService = MakeEmailService();
            emailService.SendEmail();
            DoStep3();
        }

        private void DoStep3()
        {
            Console.WriteLine("MemberManagerBase.DoStep3");
        }

        private void DoStep2()
        {
            Console.WriteLine("MemberManagerBase.DoStep2");
        }

        private void DoStep1()
        {
            Console.WriteLine("MemberManagerBase.DoStep1");
        }
    }
}
