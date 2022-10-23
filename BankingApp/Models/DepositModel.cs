using System;

namespace BankingApp
{
    public class DepositModel
    {
        public int DepositId { get; set; }

        public int AccountHolderId { get; set; }

        public decimal AmountDeposited { get; set; }

        public DateTime DateofDeposit { get; set; }
    }
}
