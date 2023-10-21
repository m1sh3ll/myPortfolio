

using SGBank.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.Models;
using System.IO;

namespace SGBank.Data
{
    public class FileAccountRepository : IAccountRepository
    {
        private string _filePath;
        public FileAccountRepository()
        {
            _filePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\FILES\Accounts.txt" ;
        }

        // list/load, create/add, update/edit, delete
        public List<Account> ListAccounts()
        {
            List<Account> accounts = new List<Account>();
            using (StreamReader sr = new StreamReader(_filePath))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Account newAccount = new Account();
                    string[] columns = line.Split(',');
                    newAccount.AccountNumber = columns[0];
                    newAccount.Name = columns[1];
                    newAccount.Balance = decimal.Parse(columns[2]);

                    switch (columns[3])
                    {
                        case "F":
                            newAccount.Type = AccountType.Free;
                            break;
                        case "P":
                            newAccount.Type = AccountType.Premium;
                            break;
                        case "B":
                            newAccount.Type = AccountType.Basic;
                            break;
                        default:
                            throw new Exception("Invalid account - Please try again!");

                    }
                    accounts.Add(newAccount);
                }
            }

            return accounts;
        }


        public Account LoadAccount(string acctNum)
        {
            var account = ListAccounts();
            var acct = account.Find(a => a.AccountNumber == acctNum);
            return acct;
        }

        public void SaveAccount(Account acct)
        {
            var accounts = ListAccounts();
            var index = accounts.FindIndex(s => s.AccountNumber == acct.AccountNumber);
            accounts[index] = acct;
            CreateAccountFile(accounts);
        }

        private string CreateCsvForAccount(Account account)
        {
            string sType = "F";
            switch (account.Type)
            {
                case AccountType.Premium:
                    sType = "P";
                    break;
                case AccountType.Basic:
                    sType = "B";
                    break;
            }

            return string.Format("{0},{1},{2},{3}", account.AccountNumber,  account.Name, account.Balance.ToString(), sType);
        }

        private void CreateAccountFile(List<Account> accounts)
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }

            using (StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.WriteLine("AccountNumber,Name,Balance,Type");
                foreach (var account in accounts)
                {
                    sw.WriteLine(CreateCsvForAccount(account));
                }
            }
        }
       






    }
}
