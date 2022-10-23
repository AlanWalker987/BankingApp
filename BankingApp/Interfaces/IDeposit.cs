using System;
using System.Collections.Generic;

namespace BankingApp
{
    public interface IDeposit
    {
        DepositModel GetDepositDetail();
        string SaveDepositDetail(DepositModel depositModel);
    }
}
