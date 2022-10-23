using System;
using System.Collections.Generic;

namespace BankingApp
{
    public interface IAccountHolder
    {
        string SaveAccountHolderDetail(AccountHolderModel accountHolderModel);
    }
}
