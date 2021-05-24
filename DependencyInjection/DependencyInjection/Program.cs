using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountmanagement = new AccountManagementService(new SpecialDatabaseAccessService());
            accountmanagement.createAccount("sumoniceiu1415", "1234");


        }
    }
}
