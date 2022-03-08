using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    /// <summary>
    /// Account Entity
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Account identication
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Person FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Person LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Account username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Account password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Account Reset Key
        /// </summary>
        public int RecoveryKey { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Account()
        {
            //empty
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Account(string fName, string lName, string usr , string pass, int recKey) : base()
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Username = usr;
            this.Password = pass;
            this.RecoveryKey = recKey;
        }
    }
}
