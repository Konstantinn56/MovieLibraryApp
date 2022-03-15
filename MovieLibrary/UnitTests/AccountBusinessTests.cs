using Business;
using Data;
using Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    /// <summary>
    /// Test for AccountBusiness
    /// </summary>
    [TestClass]
    public class AccountBusinessTests
    {
        private AccountBusiness accountBusiness;

        public AccountBusinessTests()
        {
            var accountBusiness = new AccountBusiness();
        }

        /// <summary>
        /// Test for method Get
        /// </summary>
        [TestMethod]
        public void GetAccount()
        {

        }

        //// <summary>
        /// Test for method Add when the acount doesn't existing
        /// </summary>
        [TestMethod]
        public void AddAccount_NotExistingAccount_ReturnsGenre()
        {
            ///Arrange
            Account account = new Account()
            {
                FirstName = "Velina"
            };

            ///Act
            var accountDb = accountBusiness.Get(account.FirstName);

            ///Assert
            Assert.AreEqual(account.FirstName, accountDb.FirstName);
        }

        /// <summary>
        /// Test for method Add when the account exist
        /// </summary>
        [TestMethod]
        public void AddAccount_ExistingAccount_ThrowArgumentException()
        {
            ///Arrange
            Account account = new Account()
            {
                FirstName = "Konstatnin"
            };

            ///Act and Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => accountBusiness.Add(account));
            Assert.AreEqual("This account already exist!", exception.Message);
        }

        /// <summary>
        /// Test for method Delete
        /// </summary>
        [TestMethod]
        public void DeleteAccount()
        {

        }

        /// <summary>
        /// Test for method Update
        /// </summary>
        [TestMethod]
        public void UpdateAccount()
        {

        }
    }
}