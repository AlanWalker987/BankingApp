using Newtonsoft.Json;
using System;
using System.IO;

namespace BankingApp
{
    public class Withdrawal : IWithdraw
    {
        public WithdrawalModel GetWithdrawalDetail()
        {
            string jsonData = File.ReadAllText(@"C:\Non_work\BankingApp\JsonDB\withdrawalDetail.json");
            WithdrawalModel withdrawInfo = JsonConvert.DeserializeObject<WithdrawalModel>(jsonData) ?? new WithdrawalModel();
            return withdrawInfo;
        }

        public string SaveWithdrawalDetail(WithdrawalModel withdrawalModel)
        {
            string json = JsonConvert.SerializeObject(withdrawalModel);
            File.WriteAllText(@"C:\Non_work\BankingApp\JsonDB\withdrawalDetail.json", json);
            return "Amount Withdrawn successfully";
        }
    }
}
