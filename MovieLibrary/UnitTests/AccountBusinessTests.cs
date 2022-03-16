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
        /// Test for method Get when the account exist
        /// </summary>
        [TestMethod]
        public void GetAccount_ExistingAccount_ReturnsAccount()
        {
            
        }

        /// <summary>
        /// Test for method Get when the account doesn't exist
        /// </summary>
        [TestMethod]
        public void GetAccount_NotExistingAccount_ThrowArgumentException()
        {

        }

        //// <summary>
        /// Test for method Add when the account doesn't exist
        /// </summary>
        [TestMethod]
        public void AddAccount_NotExistingAccount_ReturnsAccount()
        {
            ///Arrange
            Account account = new Account()
            {
                FirstName = "Georgi"
            };

            ///Act
            accountBusiness.Add(account);
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
        /// Test for method Delete when the account exist
        /// </summary>
        [TestMethod]
        public void DeleteAccount_ExistingAccount_RemovesAccount()
        {
            Account account = new Account()
            {
                AId = 3,
                FirstName = "Dimitar"
            };

            ///Act
            var accountDb = accountBusiness.Get(account.FirstName);
            accountBusiness.Delete(account.AId);

            ///Assert
            Assert.AreEqual(account.FirstName, accountDb.FirstName);
        }

        /// <summary>
        /// Test for method Delete when the account doesn't exist
        /// </summary>
        [TestMethod]
        public void DeleteAccount_NotExistingAccount_ThrowArgumentException()
        {
            ///Arrange
            Account account = new Account()
            {
                AId = 5
            };

            ///Act and Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => accountBusiness.Delete(account.AId));
            Assert.AreEqual("This account doesn't exist!", exception.Message);
        }

        /// <summary>
        /// Test for method Update when the account doesn't exist
        /// </summary>
        [TestMethod]
        public void UpdateAccount_NotExistingAccount_ThrowArguentException()
        {
            ///Arrange
            Account account = new Account()
            {
                FirstName = "Samuil",
                LastName = "Petrov"
            };

            ///Act and Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => accountBusiness.Update(account));
            Assert.AreEqual("This account doesn't exist!", exception.Message);
        }

        /// <summary>
        /// Test for method Update when the account exist
        /// </summary>
        [TestMethod]
        public void UpdateAccount_ExistingAccount_ReturnsNewAccount()
        {
            ///Arrange
            Account account = new Account()
            {
                FirstName = "Velina",
                LastName = "Petrova"
            };

            ///Act
            var accountDb = accountBusiness.Get(account.LastName);
            accountBusiness.Update(account);

            ///Assert
            Assert.AreNotEqual(account.LastName, accountDb.LastName);
        }
    }
}