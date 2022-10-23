using Newtonsoft.Json;
using System;
using System.IO;

namespace BankingApp
{
    public class AccountHolder : IAccountHolder
    {
        public string SaveAccountHolderDetail(AccountHolderModel accountHolderModel)
        {
            string json = JsonConvert.SerializeObject(accountHolderModel);
            File.WriteAllText(@"C:\Non_work\BankingApp\JsonDB\accountHolderDetail.json", json);
            return "Account Created Successfully";
        }
    }
}
