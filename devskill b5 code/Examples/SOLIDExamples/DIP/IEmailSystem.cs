using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExamples.DIP
{
    public interface IEmailSystem
    {
        void SendEmail(string receiver, string subject, string body);
    }
}
