using System;

namespace BankingApp
{
    public class WithdrawalModel
    {
        public int WithdrawalId { get; set; }

        public int AccountHolderId { get; set; }

        public decimal AmountWithdrawn { get; set; }

        public DateTime DateofWithdraw { get; set; }
    }
}
