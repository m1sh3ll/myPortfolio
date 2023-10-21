using NUnit.Framework;
using SGBank.BLL;
using SGBank.Models;
using SGBank.Models.Responses;
using SGBank.Models.Interfaces;
using SGBank.BLL.DepositRules;
using SGBank.BLL.WithdrawRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.Tests
{
    [TestFixture]
    public class PremiumAccountTests
    {

        [TestCase("55555", "Premium Account", 100, AccountType.Free, 2500, false)]
        [TestCase("55555", "Premium Account", 1000, AccountType.Premium, -1000, false)]
        [TestCase("55555", "Premium Account", 100, AccountType.Premium, 2500, true)]
        public void PremiumAccountDepositRuleTest(string AccountNumber, string name, decimal balance,
                                               AccountType accountType, decimal amount, bool expectedResult)
        {
            IDeposit deposit = new NoLimitDepositRule();
            Account account = new Account();
            account.AccountNumber = AccountNumber;
            account.Name = name;
            account.Balance = balance;
            account.Type = accountType;
            AccountDepositResponse response = deposit.Deposit(account, amount);
            Assert.AreEqual(expectedResult, response.Success);
        }

        
        [TestCase("55555", "Premium Account", 100, AccountType.Free, -100, 100, false)]
        [TestCase("55555", "Premium Account", 100, AccountType.Premium, 100, 100, false)]
        [TestCase("55555", "Premium Account", 1000, AccountType.Premium, -1600, 1000, false)]
        [TestCase("55555", "Premium Account", 15000, AccountType.Premium, -5000, 10000, true)]
        [TestCase("55555", "Premium Account", 1000, AccountType.Premium, -1500, -500, true)]
        public void PremiumAccountWithdrawRuleTest(string AccountNumber, string name, decimal balance, AccountType accountType,
                                                decimal amount, decimal newBalance, bool expectedResult)
        {
            IWithdraw withdraw = new PremiumAccountWithdrawRule();
            Account account = new Account();
            account.AccountNumber = AccountNumber;
            account.Name = name;
            account.Balance = balance;
            account.Type = accountType;
            AccountWithdrawResponse response = withdraw.Withdraw(account, amount);
            Assert.AreEqual(expectedResult, response.Success);
            if (response.Success == true)
            {
                Assert.AreEqual(newBalance, account.Balance);
            }

        }


    }
}
