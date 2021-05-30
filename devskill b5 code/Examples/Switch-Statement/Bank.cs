using System;
using System.Collections.Generic;
using System.Text;

namespace Switch_Statement
{
    public class Bank
    {
        public BankBranchStatus Status { get; set; }
    }

    public enum BankBranchStatus
    {
        Open,
        Closed,
        VIPCustomersOnly
    }
}
