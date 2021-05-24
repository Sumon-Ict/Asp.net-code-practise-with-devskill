using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
   public  class AccountManagementService
    {
        private IDatabaseAccessService _databaseAccess;

        public AccountManagementService(IDatabaseAccessService databaseaccess )
        {
            _databaseAccess = databaseaccess;
        }

          public void createAccount(string email,string password)
        {
            if(!string.IsNullOrEmpty(email)&&!string.IsNullOrEmpty(password))
            {

                _databaseAccess.SaveUserInDatabase(email, password);
                try
                {
                    var emailservice = new EmailServices();
                    emailservice.SendtoEmail(email);

                }
                catch
                {
                    _databaseAccess.DeleteUserAccount(email);

                }
            }
        }
    }
}
