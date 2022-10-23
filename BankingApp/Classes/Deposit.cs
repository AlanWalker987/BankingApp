using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BankingApp
{
    public class Deposit : IDeposit
    {
        public DepositModel GetDepositDetail()
        { 
            string jsonData = File.ReadAllText(@"C:\Non_work\BankingApp\JsonDB\depositDetail.json");
            DepositModel depositInfo = JsonConvert.DeserializeObject<DepositModel>(jsonData) ?? new DepositModel();
            return depositInfo;
        }

        public string SaveDepositDetail(DepositModel depositModel)
        {
            string json = JsonConvert.SerializeObject(depositModel);
            File.WriteAllText(@"C:\Non_work\BankingApp\JsonDB\depositDetail.json", json);
            return "Amount deposited successfully";
        }
    }
}
