using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IDatabaseAccessService
    {
      public  void DeleteUserAccount(string email);

      void SaveUserInDatabase(string email, string password);



    }
}
