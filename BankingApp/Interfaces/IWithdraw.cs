using System;
using System.Collections.Generic;

namespace BankingApp
{
    public interface IWithdraw
    {
        WithdrawalModel GetWithdrawalDetail();
        string SaveWithdrawalDetail(WithdrawalModel withdrawalModel);
    }
}
