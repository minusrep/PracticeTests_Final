using Practice_Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_FinalTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Deposit_PositiveAmount_IncreasesBalance()
        {
            BankAccount account = new BankAccount();
            account.Deposit(100);
            Assert.AreEqual(100, account.GetBalance());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Deposit_NegativeAmount_ThrowsException()
        {
            BankAccount account = new BankAccount();
            account.Deposit(-100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Deposit_ZeroAmount_ThrowsException()
        {
            BankAccount account = new BankAccount();
            account.Deposit(0);
        }

        [TestMethod]
        public void Deposit_LargeAmount_IncreasesBalance()
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000000);
            Assert.AreEqual(1000000, account.GetBalance());
        }

        [TestMethod]
        public void Deposit_DecimalAmount_IncreasesBalance()
        {
            BankAccount account = new BankAccount();
            account.Deposit(50.75m);
            Assert.AreEqual(50.75m, account.GetBalance());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Deposit_VeryLargeNegativeAmount_ThrowsException()
        {
            BankAccount account = new BankAccount();
            account.Deposit(-100000);
        }

        [TestMethod]
        public void Deposit_DoubleDeposit_IncreasesBalance()
        {
            BankAccount account = new BankAccount();
            account.Deposit(50);
            account.Deposit(50);
            Assert.AreEqual(100, account.GetBalance());
        }

        [TestMethod]
        public void Withdraw_SufficientFunds_DecreasesBalance()
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            account.Withdraw(100);
            Assert.AreEqual(900, account.GetBalance());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Withdraw_InsufficientFunds_ThrowsException()
        {
            BankAccount account = new BankAccount();
            account.Deposit(90);
            account.Withdraw(100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Withdraw_ZeroAmount_ThrowsException()
        {
            BankAccount account = new BankAccount();
            account.Withdraw(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Withdraw_NegativeAmount_ThrowsException()
        {
            BankAccount account = new BankAccount();
            account.Withdraw(-50);
        }

        [TestMethod]
        public void Withdraw_LargeAmount_DecreasesBalance()
        {
            BankAccount account = new BankAccount();
            account.Deposit(2000000);
            account.Withdraw(1000000);
            Assert.AreEqual(1000000, account.GetBalance());
        }

        [TestMethod]
        public void Withdraw_DecimalAmount_DecreasesBalance()
        {
            BankAccount account = new BankAccount();
            account.Deposit(100.75m);
            account.Withdraw(30.75m);
            Assert.AreEqual(70, account.GetBalance());
        }

        [TestMethod]
        public void GetBalance_ReturnsCorrectBalance()
        {
            BankAccount account = new BankAccount();
            account.Deposit(100);
            Assert.AreEqual(100, account.GetBalance());
        }

        [TestMethod]
        public void GetBalance_AfterDepositAndWithdraw_ReturnsCorrectBalance()
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            account.Withdraw(100);
            Assert.AreEqual(900, account.GetBalance());
        }
    }
}
