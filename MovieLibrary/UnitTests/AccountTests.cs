using Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    /// <summary>
    /// Test for Account
    /// </summary>
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Account()
        {
            Account account = new Account();
            account.FirstName = "Dimitar";
            account.LastName = "Georgiev";
            account.Username = "zero123";
            account.Password = "z123456";
            account.RecoveryKey = 1234;

            Assert.IsInstanceOfType(account, typeof(Account));
        }
    }
}
