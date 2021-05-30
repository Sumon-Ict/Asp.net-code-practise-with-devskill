using System;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            var normal = CheckIfCanWalkIntoBankSwitch(new Bank() { Status = BankBranchStatus.VIPCustomersOnly }, true);
            Console.WriteLine(normal);

            var newway = CheckIfCanWalkIntoBank5(new Bank() { Status = BankBranchStatus.VIPCustomersOnly }, true);
            Console.WriteLine(newway);
        }

        #region Step 0
        static bool CheckIfCanWalkIntoBankSwitch(Bank bank, bool isVip)
        {
            bool result = false;

            switch (bank.Status)
            {
                case BankBranchStatus.Open:
                    result = true;
                    break;

                case BankBranchStatus.Closed:
                    result = false;
                    break;

                case BankBranchStatus.VIPCustomersOnly:
                    result = isVip;
                    break;

                default:
                    result = false;
                    break;
            }

            return result;
        }
        #endregion

        #region Step 1
        static bool CheckIfCanWalkIntoBank(Bank bank, bool isVip)
        {
            var result = bank.Status switch
            {
                BankBranchStatus.Open => true,
                BankBranchStatus.Closed => false,
                BankBranchStatus.VIPCustomersOnly => isVip,
                _ => false
            };

            return result;
        }
        #endregion

        #region Step 2
        static bool CheckIfCanWalkIntoBank2(Bank bank, bool isVip)
        {
            return bank.Status switch
            {
                BankBranchStatus.Open => true,
                BankBranchStatus.Closed => false,
                BankBranchStatus.VIPCustomersOnly => isVip,
                _ => false
            };
        }
        #endregion

        #region Step 3
        static bool CheckIfCanWalkIntoBank3(Bank bank, bool isVip) => bank.Status switch
        {
            BankBranchStatus.Open => true,
            BankBranchStatus.Closed => false,
            BankBranchStatus.VIPCustomersOnly => isVip,
            _ => false
        };
        #endregion

        #region Step 4
        static bool CheckIfCanWalkIntoBank4(Bank bank, bool isVip)
        {
            return bank.Status switch
            {
                BankBranchStatus.Open => true,
                BankBranchStatus.Closed => false,
                BankBranchStatus.VIPCustomersOnly when isVip => true,
                BankBranchStatus.VIPCustomersOnly when !isVip => false,
                _ => false
            };
        }
        #endregion

        #region Step 5
        static bool CheckIfCanWalkIntoBank5(Bank bank, bool isVip)
        {
            return (bank.Status, isVip) switch
            {
                (BankBranchStatus.Open, _) => true,
                (BankBranchStatus.Closed, _) => false,
                (BankBranchStatus.VIPCustomersOnly, true) => true,
                (BankBranchStatus.VIPCustomersOnly, false) => false,
                (_, _) => false
            };
        }
        #endregion

        #region Step 6
        static bool CheckIfCanWalkIntoBank6(Bank bank, bool isVip)
        {
            return bank switch
            {
                { Status: BankBranchStatus.Open } => true,
                { Status: BankBranchStatus.Closed } => false,
                { Status: BankBranchStatus.VIPCustomersOnly } => isVip,
                { Status: _ } => false
            };
        }
        #endregion
    }
}
