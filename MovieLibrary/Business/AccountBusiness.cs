using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Model;

namespace Business
{
    /// <summary>
    /// Business Logic of the Account
    /// </summary>
    public class AccountBusiness
    {
        private AccountContext accountContext = new AccountContext();

        /// <summary>
        /// Get single account from the database by Username
        /// </summary>
        public Account Get(string username)
        {
            using (accountContext = new AccountContext())
            {
                return accountContext.Accounts.Where(a => a.Username.Equals(username)).FirstOrDefault();
            }
        }

        /// <summary>
        /// Add a account to the database
        /// </summary>
        public void Add(Account account)
        {
            using (accountContext = new AccountContext())
            {
                accountContext.Accounts.Add(account);
                accountContext.SaveChanges();
            }
        }

        /// <summary>
        /// Delete a Account from the Database By Id
        /// </summary>
        public void Delete(int id)
        {
            using (accountContext = new AccountContext())
            {
                var account = accountContext.Accounts.Find(id);
                if(account != null)
                {
                    accountContext.Accounts.Remove(account);
                    accountContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Check if this recoveryKey already exists in the Database
        /// True - Already exists
        /// False - Doesn't exists
        /// </summary>
        public bool DoesThisRecoveryKeyAlreadyExists(int recoveryKey)
        {
            using (accountContext = new AccountContext())
            {
                Account account = accountContext.Accounts.Where(a => a.RecoveryKey == recoveryKey).FirstOrDefault();
                if(account == null)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Change the password of the current account with the given username
        /// The account isnt possible to be null
        /// </summary>
        public void ChangePassword(string usr, string newPass)
        {
            using (accountContext = new AccountContext())
            {
                //Its not possible to be null, because its already logged in.
                Account currentAccount = accountContext.Accounts.Where(a => a.Username.Equals(usr)).FirstOrDefault();

                if(currentAccount != null)
                {
                    Delete(currentAccount.Id);
                    currentAccount.Password = newPass;
                    currentAccount.Id = default;
                    Add(currentAccount);
                }
            }
        }
    }
}
