using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExamples.DIP
{
    public class NewEmailService : IEmailSystem
    {
        private void ProcessEmail(string email, string subject, string body)
        {
            Console.WriteLine("Using new email system");
        }

        public void SendEmail(string receiver, string subject, string body)
        {
            ProcessEmail(receiver, subject, body);
        }
    }
}
