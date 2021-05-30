using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDExamples.DIP
{
    public class MembershipService
    {
        private readonly IEmailSystem _emailSystem;
        public MembershipService(IEmailSystem emailSystem)
        {
            _emailSystem = emailSystem;
        }

        public void CreateAccount(string username, string password, string email)
        {
            // store in database
            _emailSystem.SendEmail(email, "Account created", "Welcome to Dev Skill");
        }
    }
}
