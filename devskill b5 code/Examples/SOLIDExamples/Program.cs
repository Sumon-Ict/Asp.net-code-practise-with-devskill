using SOLIDExamples.DIP;
using System;

namespace SOLIDExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailSystem = new EmailService();
            //var newEmailSystem = new NewEmailService();

            var membership = new MembershipService(emailSystem);
            membership.CreateAccount("jalaluddin", "1234", "info@devskill.com");
        }
    }
}
