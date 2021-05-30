using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractClass
{
    public abstract class User
    {
        public virtual void Login(string username, string password)
        {
            // login code need to be written here
        }

        public void Logout()
        {
            // logout code need to be written here
        }

        public abstract void ChangePassword(string newPassword);
    }
}
