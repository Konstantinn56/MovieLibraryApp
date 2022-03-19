using Data;
using Data.Model;

namespace Business
{
    /// <summary>
    /// Business Logic of the Account
    /// </summary>
    public class AccountBusiness
    {
        private ApplicationContext applicationContext = new ApplicationContext();

        /// <summary>
        /// Get an Account from the database by Username
        /// </summary>
        public Account Get(string username)
        {
            using (applicationContext = new ApplicationContext())
            {
                return applicationContext.Accounts.Where(a => a.Username.Equals(username)).FirstOrDefault();
            }
        }

        /// <summary>
        /// Add an Account to the database
        /// </summary>
        public void Add(Account account)
        {
            using (applicationContext = new ApplicationContext())
            {
                var accountDb = applicationContext.Accounts.FirstOrDefault(a => a.FirstName == account.FirstName);

                if (accountDb != null)
                {
                    throw new ArgumentException("This account already exist!");
                }
                else
                {
                    applicationContext.Accounts.Add(account);
                    applicationContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Delete an Account from the Database by Id
        /// </summary>
        public void Delete(int id)
        {
            using (applicationContext = new ApplicationContext())
            {
                var account = applicationContext.Accounts.Find(id);
                if (account != null)
                {
                    applicationContext.Accounts.Remove(account);
                    applicationContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("This account doesn't exist!");
                }
            }
        }

        /// <summary>
        /// Update an Account in the Database
        /// </summary>
        public void Update(Account account)
        {
            using (applicationContext = new ApplicationContext())
            {
                Account currentAccount = applicationContext.Accounts.Find(account.AId);
                if (currentAccount != null)
                {
                    applicationContext.Entry(currentAccount).CurrentValues.SetValues(account);
                    applicationContext.SaveChanges();
                }
                else
                { 
                    throw new ArgumentException("This account doesn't exist!");
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
            using (applicationContext = new ApplicationContext())
            {
                Account account = applicationContext.Accounts.Where(a => a.RecoveryKey == recoveryKey).FirstOrDefault();
                if(account == null)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
