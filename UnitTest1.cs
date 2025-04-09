namespace TetProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Wpłać() {
            double depositAmount = 20;
            double beginningBalance = 10;
            double expected = 30;
            BankAccount account1 = new BankAccount("Mrs. Mcay", beginningBalance);

            account1.Deposit(depositAmount);

            double actual = account1.Balance;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Wypłać() 
        {
            double withdrawAmount = 10;
            double beginningBalance = 20;
            double expected = 10;

            BankAccount account2 = new BankAccount("Mr. Dobosz", beginningBalance);
            
            account2.Withdraw(withdrawAmount);
        }

        [TestMethod]
        public void Wyplac_ThrowsException_WhenInsufficientFunds()
        {
            double withdrawAmount = 50;
            double beginningBalance = 20;

            BankAccount account = new BankAccount("Mr. Dobosz", beginningBalance);

            Assert.ThrowsException<InvalidOperationException>(() => account.Withdraw(withdrawAmount));
        }

        [TestMethod]
        public void pobierzSaldo()
        {
            double Balance = 10;
            double expected = 10;

            BankAccount account = new BankAccount("MS. Mick", Balance);
            double actual = account.Balance;
            Assert.AreEqual(expected, actual);
        }
    }
}