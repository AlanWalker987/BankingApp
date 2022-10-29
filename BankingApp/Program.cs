
using BankingApp;
using System;
using System.Linq.Expressions;

namespace BankingApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Message = String.Empty;
            DepositModel depositModel = new DepositModel();
            WithdrawalModel withdrawalmodel = new WithdrawalModel();
            Console.WriteLine("------Banking App---------");

            Console.WriteLine("Welcome to SBM Bank");

            Console.WriteLine("--------------------------");
            Console.WriteLine("Choose your options");

            Console.WriteLine("Enter 1 to create the account");
            Console.WriteLine("Enter 2 to deposit to the account");
            Console.WriteLine("Enter 3 to withdraw the amount");
            Console.WriteLine("Enter 4 to get Deposit Info");
            Console.WriteLine("Enter 5 to get withdrawal info");
            Console.WriteLine("Enter 6 to get the balance amount");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    AccountHolderModel accountHolderModel = new AccountHolderModel();

                    Console.WriteLine("Enter the Account Holder Id");
                    accountHolderModel.AccountHolderId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Account Holder Name");
                    accountHolderModel.AccountHolderName = Console.ReadLine();

                    Console.WriteLine("Enter the Account Number");
                    accountHolderModel.AccountNumber = Console.ReadLine();

                    Console.WriteLine("Enter the Account Type");
                    accountHolderModel.AccountType = Console.ReadLine();

                    Console.WriteLine("Enter the Bank Name");
                    accountHolderModel.BankName = Console.ReadLine();

                    IAccountHolder accountHolder = new AccountHolder();
                    Message = accountHolder.SaveAccountHolderDetail(accountHolderModel);
                    Console.WriteLine(Message);

                    break;
                case "2":
                    Console.WriteLine("Enter the deposit Id");
                    depositModel.DepositId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the amount you want to deposit");
                    depositModel.AmountDeposited = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Date of deposit");
                    depositModel.DateofDeposit = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Account Holder Id");
                    depositModel.AccountHolderId = Convert.ToInt32(Console.ReadLine());

                    IDeposit deposit = new Deposit();

                    Message = deposit.SaveDepositDetail(depositModel);
                    Console.WriteLine(Message);

                    break;
                case "3":
                    WithdrawalModel withdrawalModel = new WithdrawalModel();

                    Console.WriteLine("Enter the Widthdrawal Id");
                    withdrawalModel.WithdrawalId = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        Console.WriteLine("Enter the amount to withdraw");
                        withdrawalModel.AmountWithdrawn = Convert.ToInt32(Console.ReadLine());

                        if(withdrawalModel.AmountWithdrawn > depositModel.AmountDeposited)
                        {
                            throw new Exception("Insufficent Amount");
                        }
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                    Console.WriteLine("Enter the Account Holder id");
                    withdrawalModel.AccountHolderId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the date of withdrawal");
                    withdrawalModel.DateofWithdraw = Convert.ToDateTime(Console.ReadLine());

                    IWithdraw withdraw = new Withdrawal();
                    Message = withdraw.SaveWithdrawalDetail(withdrawalModel);
                    Console.WriteLine(Message);

                    break;
                case "4":
                    IDeposit depositInfo = new Deposit();
                    DepositModel depositData = depositInfo.GetDepositDetail();
                    Console.WriteLine("----Deposited Amount Info----");
                    Console.WriteLine("Account Holder ID - {0}",depositData.AccountHolderId);
                    Console.WriteLine("Deposit Id - {0}",depositData.DepositId);
                    Console.WriteLine("Deposited Amount - {0}",depositData.AmountDeposited);
                    Console.WriteLine("Date of Deposit - {0}",depositData.DateofDeposit);
                    Console.WriteLine("-----------------------------");
                    break;
                case "5":
                    IWithdraw withdrawInfo = new Withdrawal();
                    WithdrawalModel withdrawData = withdrawInfo.GetWithdrawalDetail();
                    Console.WriteLine("----Withdrawn Amount Info----");
                    Console.WriteLine("Withdrawal Id - {0}",withdrawData.WithdrawalId);
                    Console.WriteLine("Account Holder Id - {0}",withdrawData.AccountHolderId);
                    Console.WriteLine("Amount Withdrawn - {0}",withdrawData.AmountWithdrawn);
                    Console.WriteLine("Date of Withdrawal - {0}",withdrawData.DateofWithdraw);
                    Console.WriteLine("-----------------------------");
                    break;
                case "6":
                    Withdrawal withdrawInform = new Withdrawal();
                    decimal balance = withdrawInform.GetRemainingBalance();
                    Console.WriteLine("Balance in the account is {0}", balance);
                    break;
            }

            Console.ReadLine();
        }
    }
}
