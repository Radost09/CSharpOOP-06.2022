using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace P06MoneyTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> bankAcounts = CreateBankAccounts();

            string command;

            while((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(' ');
                try
                {
                    ValidateAccountData(bankAcounts, cmdArgs);
                    ReadCommands(bankAcounts, cmdArgs);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }

        private static Dictionary<int, double> CreateBankAccounts()
        {
            string[] acounts = Console.ReadLine().Split(',');
            Dictionary<int, double> bankAccountAndBalance = new Dictionary<int, double>();

            foreach (var acount in acounts)
            {
                string[] accountData = acount.Split('-');
                int accountNumber = int.Parse(accountData[0]);
                double accountBalance = double.Parse(accountData[1]);

                bankAccountAndBalance[accountNumber] = accountBalance;
            }
            return bankAccountAndBalance;
        }
        public static void ReadCommands(Dictionary<int, double> account, string[] command)
        {
            string action = command[0];
            int accountNumber = int.Parse(command[1]);
            double sum = double.Parse(command[2]);

            switch(action)
            {
                case "Deposit":
                    account[accountNumber] += sum;
                    break;
                case "Withdraw":
                    account[accountNumber] -= sum;
                    break;
            }
            Console.WriteLine($"Account {accountNumber} has new balance: {account[accountNumber]:f2}");
        }
        public static void ValidateAccountData(Dictionary<int, double> accounts, string[] command)
        {
            string action = command[0];
            int accountNumber = int.Parse(command[1]);
            double sum = double.Parse(command[2]);

            if(action != "Deposit" && action != "Withdraw")
            {
                throw new ArgumentException("Invalid command!");
            }
            if(!accounts.ContainsKey(accountNumber))
            {
                throw new ArgumentException("Invalid account!");
            }
            if(action == "Withdraw" && accounts[accountNumber] - sum < 0)
            {
                throw new InvalidOperationException("Insufficient balance!");
            }
        }
    }
}
