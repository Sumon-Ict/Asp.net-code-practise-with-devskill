using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExamples.DIP
{
    public class EmailService : IEmailSystem
    {
        public void SendEmail(string email, string subject, string body)
        {
            Console.WriteLine("Using old email system");
        }
    }
}
